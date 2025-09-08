using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public class Entry : TaskItem
{
    public Entry(DateOnly creationDate, string name, string description) : base(creationDate)
    {
        Name = name;
        Description = description;
        Items = new BindingList<ChecklistItem>();
    }

    public string Name { get; }

    public string Description { get; }

    public BindingList<ChecklistItem> Items { get; }

    public override string ToString() => Name;

    public string FullString()
    {
        string result = (IsCompleted ? "[COMPLETE] " : "")
            + (IsCanceled ? "[CANCELED] " : "")
            + Name + (string.IsNullOrEmpty(Description) ? "" : "\n" + Description) + "\n";
        result += "[Note] " + Note + "\n";
        foreach (var item in Items)
        {
            result += item.FullString();
        }
        return result;
    }

    public void AddItem(DateOnly creationDate, string itemStr) => AddItem(creationDate, itemStr, Items.Count * 10);

    public void AddItem(DateOnly creationDate, string itemStr, int seq)
    {
        ChecklistItem item = new ChecklistItem(creationDate, itemStr, seq);
        Items.Add(item);
    }

    public ChecklistItem? GetItem(int index)
    {
        if (Items.Count == 0) return null;
        if (Items.Count <= index) return null;
        if (index < 0) return null;
        return Items[index];
    }

    public override void Cancel(DateOnly cancelationDate)
    {
        if (IsCompleted) return;
        foreach (var item in Items) { item.Cancel(cancelationDate); }
        CancelationDate = cancelationDate;
    }

    public override void Complete(DateOnly completionDate)
    {
        if (IsCanceled) return;
        foreach (var item in Items) { item.Complete(completionDate); }
        CompletionDate = completionDate;
    }
}
