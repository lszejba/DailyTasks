using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public class ChecklistItem : TaskItem
{
    public ChecklistItem(string value, int seq/*, Entry parent*/)
    {
        Value = value;
        DateTime now = DateTime.Now;
        CreationDate = new DateOnly(now.Year, now.Month, now.Day);
        SequenceNumber = seq;
        //Parent = parent;
    }

    public string Value { get; }

    public int SequenceNumber { get; set; }

    //[JsonIgnore]
    //public Entry Parent { get; }

    public override void Cancel(DateOnly cancelationDate)
    {
        if (IsCompleted) return; // can't cancel already completed items
        CancelationDate = cancelationDate;
    }

    public override void Complete(DateOnly completionDate)
    {
        if (IsCanceled) return; // can't complete already canceled items
        CompletionDate = completionDate;
    }

    public override string ToString()
    {
        string result = "\t" + (IsCompleted ? "[COMPLETE] " : "") + (IsCanceled ? "[CANCELED] " : "") + Value + "\n";

        for (int i = 0; i < Notes?.Count; i++)
        {
            result += "\t[Note " + i + "]: " + Notes[i] + "\n";
        }

        return result;
    }
}
