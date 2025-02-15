using DailyTasksLibrary;

namespace DailyTasksForm
{
    partial class MainDailyTasksForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EntriesListBox = new ListBox();
            ChecklistItemsListBox = new ListBox();
            EntryNotesListBox = new ListBox();
            ChecklistItemNotesListBox = new ListBox();
            label1 = new Label();
            AddEntryButton = new Button();
            AddChecklistItemButton = new Button();
            AddEntryNoteButton = new Button();
            AddChecklistItemNoteButton = new Button();
            SuspendLayout();
            // 
            // EntriesListBox
            // 
            EntriesListBox.FormattingEnabled = true;
            EntriesListBox.ItemHeight = 15;
            EntriesListBox.Location = new Point(12, 48);
            EntriesListBox.Name = "EntriesListBox";
            EntriesListBox.Size = new Size(377, 169);
            EntriesListBox.TabIndex = 0;
            EntriesListBox.SelectedIndexChanged += EntriesListBox_SelectedIndexChanged;
            // 
            // ChecklistItemsListBox
            // 
            ChecklistItemsListBox.FormattingEnabled = true;
            ChecklistItemsListBox.ItemHeight = 15;
            ChecklistItemsListBox.Location = new Point(50, 249);
            ChecklistItemsListBox.Name = "ChecklistItemsListBox";
            ChecklistItemsListBox.Size = new Size(339, 184);
            ChecklistItemsListBox.TabIndex = 1;
            ChecklistItemsListBox.SelectedIndexChanged += ChecklistItemsListBox_SelectedIndexChanged;
            // 
            // EntryNotesListBox
            // 
            EntryNotesListBox.FormattingEnabled = true;
            EntryNotesListBox.ItemHeight = 15;
            EntryNotesListBox.Location = new Point(434, 48);
            EntryNotesListBox.Name = "EntryNotesListBox";
            EntryNotesListBox.Size = new Size(354, 169);
            EntryNotesListBox.TabIndex = 2;
            // 
            // ChecklistItemNotesListBox
            // 
            ChecklistItemNotesListBox.FormattingEnabled = true;
            ChecklistItemNotesListBox.ItemHeight = 15;
            ChecklistItemNotesListBox.Location = new Point(434, 249);
            ChecklistItemNotesListBox.Name = "ChecklistItemNotesListBox";
            ChecklistItemNotesListBox.Size = new Size(354, 184);
            ChecklistItemNotesListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 4;
            label1.Text = "15.02.2025 (Saturday)";
            // 
            // AddEntryButton
            // 
            AddEntryButton.Location = new Point(361, 22);
            AddEntryButton.Name = "AddEntryButton";
            AddEntryButton.Size = new Size(28, 25);
            AddEntryButton.TabIndex = 5;
            AddEntryButton.Text = "+";
            AddEntryButton.UseVisualStyleBackColor = true;
            AddEntryButton.Click += AddEntryButton_Click;
            // 
            // AddChecklistItemButton
            // 
            AddChecklistItemButton.Location = new Point(361, 223);
            AddChecklistItemButton.Name = "AddChecklistItemButton";
            AddChecklistItemButton.Size = new Size(28, 25);
            AddChecklistItemButton.TabIndex = 6;
            AddChecklistItemButton.Text = "+";
            AddChecklistItemButton.UseVisualStyleBackColor = true;
            AddChecklistItemButton.Click += AddChecklistItemButton_Click;
            // 
            // AddEntryNoteButton
            // 
            AddEntryNoteButton.Location = new Point(761, 22);
            AddEntryNoteButton.Name = "AddEntryNoteButton";
            AddEntryNoteButton.Size = new Size(28, 25);
            AddEntryNoteButton.TabIndex = 7;
            AddEntryNoteButton.Text = "+";
            AddEntryNoteButton.UseVisualStyleBackColor = true;
            AddEntryNoteButton.Click += AddEntryNoteButton_Click;
            // 
            // AddChecklistItemNoteButton
            // 
            AddChecklistItemNoteButton.Location = new Point(761, 223);
            AddChecklistItemNoteButton.Name = "AddChecklistItemNoteButton";
            AddChecklistItemNoteButton.Size = new Size(28, 25);
            AddChecklistItemNoteButton.TabIndex = 8;
            AddChecklistItemNoteButton.Text = "+";
            AddChecklistItemNoteButton.UseVisualStyleBackColor = true;
            AddChecklistItemNoteButton.Click += AddChecklistItemNoteButton_Click;
            // 
            // MainDailyTasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddChecklistItemNoteButton);
            Controls.Add(AddEntryNoteButton);
            Controls.Add(AddChecklistItemButton);
            Controls.Add(AddEntryButton);
            Controls.Add(label1);
            Controls.Add(ChecklistItemNotesListBox);
            Controls.Add(EntryNotesListBox);
            Controls.Add(ChecklistItemsListBox);
            Controls.Add(EntriesListBox);
            Name = "MainDailyTasksForm";
            Text = "Daily Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EntriesListBox;
        private ListBox ChecklistItemsListBox;
        private ListBox EntryNotesListBox;
        private ListBox ChecklistItemNotesListBox;
        private Label label1;
        private Button AddEntryButton;
        private Button AddChecklistItemButton;
        private Button AddEntryNoteButton;
        private Button AddChecklistItemNoteButton;
    }
}
