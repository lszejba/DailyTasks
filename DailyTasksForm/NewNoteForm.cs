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
    public partial class NewNoteForm : Form
    {
        ItemsManager _manager;
        TaskItem _parent;
        public NewNoteForm(ItemsManager manager, TaskItem parent)
        {
            _manager = manager;
            _parent = parent;
            InitializeComponent();
            ParentNameLabel.Text = "Parent: " + _parent.ToString() + "[" + _parent.GetType().Name + "]";
            NoteRTFBox.Rtf = parent.Note ?? "";
        }

        public void NoteRTFBox_TextChanged(object sender, EventArgs e)
        {
            EditNoteButton.Enabled = NoteRTFBox.Rtf.Length > 0;
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            _manager.AddNote(_parent, NoteRTFBox.Rtf ?? string.Empty);
            this.Close();
        }
    }
}
