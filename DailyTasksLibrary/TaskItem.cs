using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public abstract class TaskItem
{
    public bool IsCompleted { get; set; }
    public bool IsCanceled { get; set; }
    public bool IsExpired { get; set; }
    public DateOnly CreationDate { get; set; }
    public DateOnly CompletionDate { get; set; }
    public DateOnly CancelationDate { get; set; }
    public DateOnly ExpirationDate { get; set; }

    public List<string>? Notes { get; set; }

    public abstract void Complete(DateOnly completionDate);

    public abstract void Cancel(DateOnly cancelationDate);
}
