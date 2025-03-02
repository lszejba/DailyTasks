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
            label1 = new Label();
            groupBox1 = new GroupBox();
            AddChecklistItemNoteButton = new Button();
            ChecklistItemNotesListBox = new ListBox();
            groupBox2 = new GroupBox();
            AddChecklistItemButton = new Button();
            ChecklistItemsListBox = new ListBox();
            groupBox3 = new GroupBox();
            AddEntryButton = new Button();
            EntriesListBox = new ListBox();
            groupBox4 = new GroupBox();
            AddEntryNoteButton = new Button();
            EntryNotesListBox = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(AddChecklistItemNoteButton);
            groupBox1.Controls.Add(ChecklistItemNotesListBox);
            groupBox1.Location = new Point(594, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 287);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // AddChecklistItemNoteButton
            // 
            AddChecklistItemNoteButton.Anchor = AnchorStyles.Top;
            AddChecklistItemNoteButton.Location = new Point(520, 1);
            AddChecklistItemNoteButton.Name = "AddChecklistItemNoteButton";
            AddChecklistItemNoteButton.Size = new Size(28, 25);
            AddChecklistItemNoteButton.TabIndex = 10;
            AddChecklistItemNoteButton.Text = "+";
            AddChecklistItemNoteButton.UseVisualStyleBackColor = true;
            AddChecklistItemNoteButton.Click += AddChecklistItemNoteButton_Click;
            // 
            // ChecklistItemNotesListBox
            // 
            ChecklistItemNotesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChecklistItemNotesListBox.FormattingEnabled = true;
            ChecklistItemNotesListBox.ItemHeight = 15;
            ChecklistItemNotesListBox.Location = new Point(12, 32);
            ChecklistItemNotesListBox.Name = "ChecklistItemNotesListBox";
            ChecklistItemNotesListBox.Size = new Size(536, 244);
            ChecklistItemNotesListBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(AddChecklistItemButton);
            groupBox2.Controls.Add(ChecklistItemsListBox);
            groupBox2.Location = new Point(6, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(559, 288);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // AddChecklistItemButton
            // 
            AddChecklistItemButton.Anchor = AnchorStyles.Top;
            AddChecklistItemButton.Location = new Point(525, 1);
            AddChecklistItemButton.Name = "AddChecklistItemButton";
            AddChecklistItemButton.Size = new Size(28, 25);
            AddChecklistItemButton.TabIndex = 8;
            AddChecklistItemButton.Text = "+";
            AddChecklistItemButton.UseVisualStyleBackColor = true;
            AddChecklistItemButton.Click += AddChecklistItemButton_Click;
            // 
            // ChecklistItemsListBox
            // 
            ChecklistItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChecklistItemsListBox.FormattingEnabled = true;
            ChecklistItemsListBox.ItemHeight = 15;
            ChecklistItemsListBox.Location = new Point(38, 32);
            ChecklistItemsListBox.Name = "ChecklistItemsListBox";
            ChecklistItemsListBox.Size = new Size(515, 244);
            ChecklistItemsListBox.TabIndex = 7;
            ChecklistItemsListBox.SelectedIndexChanged += ChecklistItemsListBox_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(AddEntryButton);
            groupBox3.Controls.Add(EntriesListBox);
            groupBox3.Location = new Point(6, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(559, 288);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // AddEntryButton
            // 
            AddEntryButton.Anchor = AnchorStyles.Top;
            AddEntryButton.Location = new Point(525, 2);
            AddEntryButton.Name = "AddEntryButton";
            AddEntryButton.Size = new Size(28, 25);
            AddEntryButton.TabIndex = 7;
            AddEntryButton.Text = "+";
            AddEntryButton.UseVisualStyleBackColor = true;
            AddEntryButton.Click += AddEntryButton_Click;
            // 
            // EntriesListBox
            // 
            EntriesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EntriesListBox.FormattingEnabled = true;
            EntriesListBox.ItemHeight = 15;
            EntriesListBox.Location = new Point(3, 30);
            EntriesListBox.Name = "EntriesListBox";
            EntriesListBox.Size = new Size(553, 244);
            EntriesListBox.TabIndex = 6;
            EntriesListBox.SelectedIndexChanged += EntriesListBox_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(AddEntryNoteButton);
            groupBox4.Controls.Add(EntryNotesListBox);
            groupBox4.Location = new Point(594, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(560, 288);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // AddEntryNoteButton
            // 
            AddEntryNoteButton.Anchor = AnchorStyles.Top;
            AddEntryNoteButton.Location = new Point(520, -3);
            AddEntryNoteButton.Name = "AddEntryNoteButton";
            AddEntryNoteButton.Size = new Size(28, 25);
            AddEntryNoteButton.TabIndex = 9;
            AddEntryNoteButton.Text = "+";
            AddEntryNoteButton.UseVisualStyleBackColor = true;
            AddEntryNoteButton.Click += AddEntryNoteButton_Click;
            // 
            // EntryNotesListBox
            // 
            EntryNotesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EntryNotesListBox.FormattingEnabled = true;
            EntryNotesListBox.ItemHeight = 15;
            EntryNotesListBox.Location = new Point(12, 28);
            EntryNotesListBox.Name = "EntryNotesListBox";
            EntryNotesListBox.Size = new Size(536, 244);
            EntryNotesListBox.TabIndex = 8;
            // 
            // MainDailyTasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 627);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MainDailyTasksForm";
            Text = "Daily Tasks";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Button AddChecklistItemNoteButton;
        private ListBox ChecklistItemNotesListBox;
        private GroupBox groupBox2;
        private Button AddChecklistItemButton;
        private ListBox ChecklistItemsListBox;
        private GroupBox groupBox3;
        private Button AddEntryButton;
        private ListBox EntriesListBox;
        private GroupBox groupBox4;
        private Button AddEntryNoteButton;
        private ListBox EntryNotesListBox;
    }
}
