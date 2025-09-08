using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public class ChecklistItem : TaskItem
{
    public ChecklistItem(DateOnly creationDate, string value, int seq) : base(creationDate)
    {
        Value = value;
        SequenceNumber = seq;
    }

    public string Value { get; }

    public int SequenceNumber { get; set; }

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

    public override string ToString() => Value;

    public string FullString()
    {
        string result = "\t" + (IsCompleted ? "[COMPLETE] " : "") + (IsCanceled ? "[CANCELED] " : "") + Value + "\n";
        result += "\t[Note]: " + Note + "\n";

        return result;
    }
}
