using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public abstract class TaskItem
{
    public bool IsCompleted => (CompletionDate != null && CompletionDate <= ItemsManager.CurrentDate);
    public bool IsCanceled => (CancelationDate != null && CancelationDate <= ItemsManager.CurrentDate);
    public bool IsExpired => false;
    public DateOnly CreationDate { get; set; }
    public DateOnly? CompletionDate { get; set; }
    public DateOnly? CancelationDate { get; set; }
    public DateOnly? ExpirationDate { get; set; }

    public BindingList<string>? Notes { get; set; }

    public abstract void Complete(DateOnly completionDate);

    public abstract void Cancel(DateOnly cancelationDate);

    public virtual void AddNote(string note)
    {
        if (Notes == null)
        {
            Notes = new BindingList<string>();
        }
        Notes.Add(note);
    }
}
