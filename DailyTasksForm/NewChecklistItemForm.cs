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

    public void AddNewChecklistItemButton_Click(object sender, EventArgs e)
    {
        if (newItemsGridView.Rows.Count == 0)
        {
            return;
        }
        string prefix = string.Empty;
        bool isFirstParent = firstAsParentCheckBox.Checked;
        foreach (DataGridViewRow row in newItemsGridView.Rows)
        {
            if (!row.IsNewRow)
            {
                string name = row.Cells[0].Value?.ToString() ?? string.Empty;
                string note = row.Cells[1].Value?.ToString() ?? string.Empty;
                if (name.Length > 0)
                {
                    if (isFirstParent)
                    {
                        if (prefix == string.Empty)
                        {
                            prefix = name;
                        }
                        else
                        {
                            name = prefix + ": " + name;
                        }
                    }
                    // Translate to RTF
                    note = note
                        .Replace(@"\", @"\\")
                        .Replace("{", @"\{")
                        .Replace("}", @"\}")
                        .Replace("\n", @"\par ");

                    string rtfNote = @"{\rtf1\ansi " + note + "}";
                    _manager.AddItem(_parent, ItemsManager.CurrentDate, name, rtfNote);
                }
            }
        }
        //_manager.AddItem(_parent, ItemsManager.CurrentDate, ChecklistItemNameTextBox.Text);
        this.Close();
    }
}
