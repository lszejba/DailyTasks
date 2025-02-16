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

public partial class NewChecklistItemForm : Form
{
    ItemsManager _manager;
    Entry _parent;
    public NewChecklistItemForm(ItemsManager manager, Entry parent)
    {
        _manager = manager;
        _parent = parent;
        InitializeComponent();
        ParentNameLabel.Text = "Parent " + parent.Name;
    }

    public void ChecklistNameTextBox_TextChanged(object sender, EventArgs e)
    {
        AddNewChecklistItemButton.Enabled = ChecklistItemNameTextBox.Text.Length > 0;
    }

    public void AddNewChecklistItemButton_Click(object sender, EventArgs e)
    {
        _manager.AddItem(_parent, ItemsManager.CurrentDate, ChecklistItemNameTextBox.Text);
        this.Close();
    }
}
