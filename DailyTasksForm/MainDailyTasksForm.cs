using DailyTasksLibrary;
using System.Text;

namespace DailyTasksForm;

public partial class MainDailyTasksForm : Form
{
    private ItemsManager manager;
    private ContextMenuStrip entriesContextMenu;
    private ContextMenuStrip checklistItemsContextMenu;
    private System.Windows.Forms.Timer debounceTimer;
    public MainDailyTasksForm()
    {
        debounceTimer = new System.Windows.Forms.Timer();
        debounceTimer.Interval = 2000; // in ms
        debounceTimer.Tick += DebounceTimer_Tick;
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
            EntriesNotesRichTextBox.Rtf = selectedEntry.Note;
        }
    }

    private void ChecklistItemsListBox_SelectedIndexChanged(object sender, EventArgs args)
    {
        if (ChecklistItemsListBox.SelectedItem is ChecklistItem selectedItem)
        {
            ChecklistItemNotesRichTextBox.Rtf = selectedItem.Note;
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

    private void SaveNotes()
    {
        List<Tuple<TaskItem, string>> notes = new List<Tuple<TaskItem, string>>();
        ChecklistItem? selectedItem = (ChecklistItem?)ChecklistItemsListBox.SelectedItem;
        if (selectedItem is not null)
        {
            notes.Add(new Tuple<TaskItem, string>(selectedItem, ChecklistItemNotesRichTextBox.Rtf ?? string.Empty));
        }
        Entry? selectedEntry = (Entry?)EntriesListBox.SelectedItem;
        if (selectedEntry is not null)
        {
            notes.Add(new Tuple<TaskItem, string>(selectedEntry, EntriesNotesRichTextBox.Rtf ?? string.Empty));
        }

        manager.AddNotes(notes);
    }

    private void DebounceTimer_Tick(object sender, EventArgs e)
    {
        debounceTimer.Stop();
        SaveNotes();
    }

    private void RichTextBox_TextChanged(object sender, EventArgs e)
    {
        debounceTimer.Stop();
        debounceTimer.Start();
    }

}
