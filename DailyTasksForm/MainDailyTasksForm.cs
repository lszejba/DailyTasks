using DailyTasksLibrary;

namespace DailyTasksForm;

public partial class MainDailyTasksForm : Form
{
    private ItemsManager manager;
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

    }

    private void AddChecklistItemNoteButton_Click(object sender, EventArgs e)
    {

    }
}
