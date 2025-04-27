using DailyTasksLibrary;
using System.Text;

namespace DailyTasksForm;

public partial class MainDailyTasksForm : Form
{
    private ItemsManager manager;
    private ContextMenuStrip entriesContextMenu;
    private ContextMenuStrip checklistItemsContextMenu;
    public MainDailyTasksForm()
    {
        InitializeData();
        InitializeComponent();
        InitialSetup();
    }

    private void InitializeData()
    {
        manager = new ItemsManager();
        manager.LoadTasks();
    }

    private void InitialSetup()
    {
        label1.Text = ItemsManager.CurrentDate.ToString() + " (" + ItemsManager.CurrentDate.DayOfWeek.ToString() + ")";

        EntriesListBox.DataSource = manager.Entries;

        entriesContextMenu = new ContextMenuStrip();
        ToolStripMenuItem entriesContextMenuCompleteItem = new ToolStripMenuItem();
        entriesContextMenuCompleteItem.Name = "entryComplete";
        entriesContextMenuCompleteItem.Text = "Complete Entry";
        entriesContextMenu.Items.Add(entriesContextMenuCompleteItem);
        ToolStripMenuItem entriesContextMenuCancelItem = new ToolStripMenuItem();
        entriesContextMenuCancelItem.Name = "entryCancel";
        entriesContextMenuCancelItem.Text = "Cancel Entry";
        entriesContextMenu.Items.Add(entriesContextMenuCancelItem);
        entriesContextMenu.ItemClicked += EntriesContextMenu_ItemClicked;
        EntriesListBox.ContextMenuStrip = entriesContextMenu;

        checklistItemsContextMenu = new ContextMenuStrip();
        ToolStripMenuItem checklistItemsContextMenuCompleteItem = new ToolStripMenuItem();
        checklistItemsContextMenuCompleteItem.Name = "checklistItemComplete";
        checklistItemsContextMenuCompleteItem.Text = "Complete Item";
        checklistItemsContextMenu.Items.Add(checklistItemsContextMenuCompleteItem);
        ToolStripMenuItem checklistItemsContextMenuCancelItem = new ToolStripMenuItem();
        checklistItemsContextMenuCancelItem.Name = "checklistItemCancel";
        checklistItemsContextMenuCancelItem.Text = "Cancel Item";
        checklistItemsContextMenu.Items.Add(checklistItemsContextMenuCancelItem);
        checklistItemsContextMenu.ItemClicked += ChecklistItemsContextMenu_ItemClicked;
        ChecklistItemsListBox.ContextMenuStrip = checklistItemsContextMenu;
    }

    private void ChecklistItemsContextMenu_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
    {
        var selectedItem = ChecklistItemsListBox.SelectedItem as ChecklistItem;
        switch (e.ClickedItem.Name)
        {
            case "checklistItemComplete":
                if (selectedItem is not null)
                {
                    manager.CompleteItem(selectedItem);
                }
                break;
            case "checklistItemCancel":
                if (selectedItem is not null)
                {
                    manager.CancelItem(selectedItem);
                }
                break;
            default:
                break;
        }
        ChecklistItemsListBox.DataSource = null;
        Thread.Sleep(500);
        ChecklistItemsListBox.DataSource = (EntriesListBox.SelectedItem as Entry).Items;
    }

    private void EntriesContextMenu_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
    {
        var selectedEntry = EntriesListBox.SelectedItem as Entry;
        switch (e.ClickedItem.Name)
        {
            case "entryComplete":
                if (selectedEntry is not null)
                {
                    manager.CompleteItem(selectedEntry);
                }
                break;
            case "entryCancel":
                if (selectedEntry is not null)
                {
                    manager.CancelItem(selectedEntry);
                }
                break;
            default:
                break;
        }
        EntriesListBox.DataSource = null;
        Thread.Sleep(500);
        EntriesListBox.DataSource = manager.Entries;
        ChecklistItemsListBox.Refresh(); // doesn't work
    }

    private void EntriesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (EntriesListBox.SelectedItem is Entry selectedEntry)
        {
            ChecklistItemsListBox.DataSource = selectedEntry.Items;
            //EntryNotesListBox.DataSource = selectedEntry.Notes;
            //StringBuilder sb = new StringBuilder();
            //sb.Append(@"{\rtf1\ansi ");
            //foreach (var note in selectedEntry.RTFNotes)//(string note in selectedEntry.Notes)
            //{
            //    sb.Append(note.RTFText + @"\par\r\n ");
            //}
            //sb.Append(@"}");
            EntriesNotesRichTextBox.Rtf = selectedEntry.Note;// RTFNote.RTFText;//sb.ToString();
        }
    }

    private void ChecklistItemsListBox_SelectedIndexChanged(object sender, EventArgs args)
    {
        if (ChecklistItemsListBox.SelectedItem is ChecklistItem selectedItem)
        {
            //ChecklistItemNotesListBox.DataSource = selectedItem.Notes;
            ChecklistItemNotesRichTextBox.Rtf = selectedItem.Note;// RTFNote.RTFText;
        }
    }

    private void AddEntryButton_Click(object sender, EventArgs e)
    {
        var newForm = new NewEntryForm(manager);
        newForm.ShowDialog();
    }

    private void AddChecklistItemButton_Click(object sender, EventArgs e)
    {
        Entry? entry = EntriesListBox.SelectedItem as Entry;
        if (entry is not null)
        {
            var newForm = new NewChecklistItemForm(manager, entry);
            newForm.ShowDialog();
        }
    }

    private void AddEntryNoteButton_Click(object sender, EventArgs e)
    {
        Entry? entry = EntriesListBox.SelectedItem as Entry;
        if (entry is not null)
        {
            var newForm = new NewNoteForm(manager, entry);
            newForm.ShowDialog();
        }
    }

    private void AddChecklistItemNoteButton_Click(object sender, EventArgs e)
    {
        ChecklistItem? item = ChecklistItemsListBox.SelectedItem as ChecklistItem;
        if (item is not null)
        {
            var newForm = new NewNoteForm(manager, item);
            newForm.ShowDialog();
        }
    }

    private void EntriesListBox_DrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index < 0) return;
        TaskItem item = (TaskItem)EntriesListBox.Items[e.Index];
        Color c = item.GetColor();
        SolidBrush foreBrush = new SolidBrush(c);
        SolidBrush backBrush = new SolidBrush(e.BackColor);
        e.Graphics.FillRectangle(backBrush, e.Bounds);
        e.Graphics.DrawString(item.ToString(), e.Font, foreBrush, e.Bounds, StringFormat.GenericDefault);

        backBrush.Dispose();
        foreBrush.Dispose();
    }

    private void ChecklistItemsListBox_DrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index < 0) return;
        TaskItem item = (TaskItem)ChecklistItemsListBox.Items[e.Index];
        Color c = item.GetColor();
        SolidBrush foreBrush = new SolidBrush(c);
        SolidBrush backBrush = new SolidBrush(e.BackColor);
        e.Graphics.FillRectangle(backBrush, e.Bounds);
        e.Graphics.DrawString(item.ToString(), e.Font, foreBrush, e.Bounds, StringFormat.GenericDefault);

        backBrush.Dispose();
        foreBrush.Dispose();
    }
}
