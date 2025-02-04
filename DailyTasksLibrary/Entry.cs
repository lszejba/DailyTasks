using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public class Entry : TaskItem
{
    public Entry(DateOnly date, string name, string description)
    {
        Name = name;
        Description = description;
        CreationDate = date;
        Items = new List<ChecklistItem>();
    }

    public string Name { get; }

    public string Description { get; }

    public List<ChecklistItem> Items { get; }

    public override string ToString()
    {
        string result = (IsCompleted ? "[COMPLETE] " : "") + (IsCanceled ? "[CANCELED] " : "") + Name + (string.IsNullOrEmpty(Description) ? "" : "\n" + Description) + "\n";
        foreach (var item in Items)
        {
            result += item.ToString();//"\t" + item.Value + "\n";
        }
        return result;
    }

    public void AddItem(string itemStr)
    {
        AddItem(itemStr, Items.Count * 10);
    }

    public void AddItem(string itemStr, int seq)
    {
        ChecklistItem item = new ChecklistItem(itemStr, seq/*, this*/);
        Items.Add(item);
    }

    //List<ChecklistItem> items;

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
