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

namespace DailyTasksForm
{
    public partial class UpdateItemForm : Form
    {
        ItemsManager _manager;
        Entry _entry;
        ChecklistItem _checklistItem;

        public UpdateItemForm(ItemsManager manager, Entry entry)
        {
            InitializeComponent();
            _manager = manager;
            _entry = entry ?? throw new ArgumentNullException(nameof(entry));
            itemNameTextBox.Text = _entry.Name;
            itemNoteTextBox.Rtf = _entry.Note;
        }

        public UpdateItemForm(ItemsManager manager, ChecklistItem item)
        {
            InitializeComponent();
            _manager = manager;
            _checklistItem = item ?? throw new ArgumentNullException(nameof(item));
            itemNameTextBox.Text = _checklistItem.Value;
            itemNoteTextBox.Rtf = _checklistItem.Note;
        }

        private void saveItemEditButton_Click(object sender, EventArgs e)
        {
            if (_entry is not null)
            {
                _entry.Name = itemNameTextBox.Text;
                _entry.AddNote(itemNoteTextBox.Rtf);
            }
            else
            {
                _checklistItem.Value = itemNameTextBox.Text;
                _checklistItem.AddNote(itemNoteTextBox.Rtf);
            }
            _manager.SaveAll();
            this.Close();
        }
    }
}
