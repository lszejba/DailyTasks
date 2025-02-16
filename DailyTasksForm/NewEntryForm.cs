using DailyTasksLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTasksForm;

public partial class NewEntryForm : Form
{
    ItemsManager _manager;
    public NewEntryForm(ItemsManager manager)
    {
        _manager = manager;
        InitializeComponent();
    }

    public void EntryNameTextBox_TextChanged(object sender, EventArgs e)
    {
        addNewEntryButton.Enabled = entryNameTextBox.Text.Length > 0;
    }

    private void addNewEntryButton_Click(object sender, EventArgs e)
    {
        _manager.AddEntry(ItemsManager.CurrentDate, entryNameTextBox.Text, string.Empty);
        this.Close();
    }
}
