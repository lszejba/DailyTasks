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
        ApplyTheme();
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
        ToolStripMenuItem entriesContextMenuEditItem = new ToolStripMenuItem();
        entriesContextMenuEditItem.Name = "entryEdit";
        entriesContextMenuEditItem.Text = "Edit Entry";
        entriesContextMenu.Items.Add(entriesContextMenuEditItem);
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
        ToolStripMenuItem checklistItemsContextMenuEditItem = new ToolStripMenuItem();
        checklistItemsContextMenuEditItem.Name = "checklistItemEdit";
        checklistItemsContextMenuEditItem.Text = "Edit Item";
        checklistItemsContextMenu.Items.Add(checklistItemsContextMenuEditItem);
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

    private void ApplyTheme()
    {
        if (StyleHelper.IsSystemDarkTheme())
        {
            BackColor = SystemColors.ControlDark;
        }
        else
        {
            BackColor = SystemColors.ControlDark;
        }
    }

    private void ChecklistItemsContextMenu_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
    {
        var selectedItem = ChecklistItemsListBox.SelectedItem as ChecklistItem;
        switch (e.ClickedItem.Name)
        {
            case "checklistItemEdit":
                if (selectedItem is not null)
                {
                    var updateForm = new UpdateItemForm(manager, selectedItem);
                    updateForm.ShowDialog(this);
                }
                break;
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
            case "entryEdit":
                if (selectedEntry is not null)
                {
                    var updateForm = new UpdateItemForm(manager, selectedEntry);
                    updateForm.ShowDialog(this);
                }
                break;
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
        EntriesNotesRichTextBox.Rtf = String.Empty;
        if (EntriesListBox.SelectedItem is Entry selectedEntry)
        {
            ChecklistItemsListBox.DataSource = selectedEntry.Items;
            EntriesNotesRichTextBox.Rtf = selectedEntry.Note;
        }
    }

    private void ChecklistItemsListBox_SelectedIndexChanged(object sender, EventArgs args)
    {
        ChecklistItemNotesRichTextBox.Rtf = String.Empty;
        if (ChecklistItemsListBox.SelectedItem is ChecklistItem selectedItem)
        {
            ChecklistItemNotesRichTextBox.Rtf = selectedItem.Note;
        }
    }

    private void AddEntryButton_Click(object sender, EventArgs e)
    {
        var newForm = new NewEntryForm(manager);
        newForm.ShowDialog(this);
    }

    private void AddChecklistItemButton_Click(object sender, EventArgs e)
    {
        Entry? entry = EntriesListBox.SelectedItem as Entry;
        if (entry is not null)
        {
            var newForm = new NewChecklistItemForm(manager, entry);
            newForm.ShowDialog(this);
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
