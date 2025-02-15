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
    ItemsManager manager;
    public NewEntryForm(ItemsManager manager)
    {
        this.manager = manager;
        InitializeComponent();
    }

    public void EntryNameTextBox_TextChanged(object sender, EventArgs e)
    {
        addNewEntryButton.Enabled = entryNameTextBox.Text.Length > 0;
    }
}
