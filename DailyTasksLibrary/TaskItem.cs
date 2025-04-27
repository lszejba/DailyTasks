using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public abstract class TaskItem
{
    protected TaskItem(DateOnly creationDate)
    {
        CreationDate = creationDate;
        //Notes = [];
        //RTFNote = new Note(creationDate, string.Empty);
    }

    public bool IsCompleted => (CompletionDate != null && CompletionDate <= ItemsManager.CurrentDate);
    public bool IsCanceled => (CancelationDate != null && CancelationDate <= ItemsManager.CurrentDate);
    public bool IsExpired => false;
    public DateOnly CreationDate { get; set; }
    public DateOnly? CompletionDate { get; set; }
    public DateOnly? CancelationDate { get; set; }
    public DateOnly? ExpirationDate { get; set; }

    public BindingList<string> Notes { get; set; }
    //public Note RTFNote { get; }

    public string Note { get; set; }

    public abstract void Complete(DateOnly completionDate);

    public abstract void Cancel(DateOnly cancelationDate);

    public void AddNote(string note)
    {
        Note = note;
        //RTFNote = new Note(ItemsManager.CurrentDate, rtfText);
        //RTFNote.RTFText = rtfText;
        //RTFNotes.Add(note);
        //Notes.Add(note);
    }

    public Color GetColor()
    {
        Color result = Color.Black;

        if (IsCanceled) result = Color.LightGray;
        if (IsCompleted) result = Color.Green;
        if (IsExpired) result = Color.Orange;

        return result;
    }
}
