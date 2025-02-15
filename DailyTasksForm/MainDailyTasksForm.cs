using DailyTasksLibrary;

namespace DailyTasksForm;

public partial class MainDailyTasksForm : Form
{
    private ItemsManager manager;
    public MainDailyTasksForm()
    {
        InitializeData();
        InitializeComponent();
    }

    private void InitializeData()
    {
        manager = new ItemsManager();
        manager.LoadTasks();
    }

    private void EntriesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (EntriesListBox.SelectedItem is Entry selectedEntry)
        {
            ChecklistItemsListBox.DataSource = selectedEntry.Items;
            EntryNotesListBox.DataSource = selectedEntry.Notes;
        }
    }

    private void ChecklistItemsListBox_SelectedIndexChanged(object sender, EventArgs args)
    {
        if (ChecklistItemsListBox.SelectedItem is ChecklistItem selectedItem)
        {
            ChecklistItemNotesListBox.DataSource = selectedItem.Notes;
        }
    }

    private void AddEntryButton_Click(object sender, EventArgs e)
    {

    }

    private void AddChecklistItemButton_Click(object sender, EventArgs e)
    {

    }

    private void AddEntryNoteButton_Click(object sender, EventArgs e)
    {

    }

    private void AddChecklistItemNoteButton_Click(object sender, EventArgs e)
    {

    }
}
