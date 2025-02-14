using DailyTasksLibrary;

namespace DailyTasksForm;

public partial class Form1 : Form
{
    private ItemsManager manager;
    public Form1()
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
}
