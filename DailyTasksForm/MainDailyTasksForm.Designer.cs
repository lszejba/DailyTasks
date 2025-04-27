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
            AddChecklistItemNoteButton = new Button();
            groupBox2 = new GroupBox();
            AddChecklistItemButton = new Button();
            ChecklistItemsListBox = new ListBox();
            groupBox3 = new GroupBox();
            AddEntryButton = new Button();
            EntriesListBox = new ListBox();
            EntriesNotesRichTextBox = new RichTextBox();
            ChecklistItemNotesRichTextBox = new RichTextBox();
            AddEntryNoteButton = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // AddChecklistItemNoteButton
            // 
            AddChecklistItemNoteButton.Anchor = AnchorStyles.Top;
            AddChecklistItemNoteButton.Location = new Point(1173, 335);
            AddChecklistItemNoteButton.Name = "AddChecklistItemNoteButton";
            AddChecklistItemNoteButton.Size = new Size(65, 25);
            AddChecklistItemNoteButton.TabIndex = 10;
            AddChecklistItemNoteButton.Text = "Edit note";
            AddChecklistItemNoteButton.UseVisualStyleBackColor = true;
            AddChecklistItemNoteButton.Click += AddChecklistItemNoteButton_Click;
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
            groupBox2.Text = "Checklist Items";
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
            ChecklistItemsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            ChecklistItemsListBox.FormattingEnabled = true;
            ChecklistItemsListBox.ItemHeight = 15;
            ChecklistItemsListBox.Location = new Point(38, 32);
            ChecklistItemsListBox.Name = "ChecklistItemsListBox";
            ChecklistItemsListBox.Size = new Size(515, 244);
            ChecklistItemsListBox.TabIndex = 7;
            ChecklistItemsListBox.DrawItem += ChecklistItemsListBox_DrawItem;
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
            groupBox3.Text = "Entries";
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
            EntriesListBox.DrawMode = DrawMode.OwnerDrawFixed;
            EntriesListBox.FormattingEnabled = true;
            EntriesListBox.ItemHeight = 15;
            EntriesListBox.Location = new Point(3, 30);
            EntriesListBox.Name = "EntriesListBox";
            EntriesListBox.Size = new Size(553, 244);
            EntriesListBox.TabIndex = 6;
            EntriesListBox.DrawItem += EntriesListBox_DrawItem;
            EntriesListBox.SelectedIndexChanged += EntriesListBox_SelectedIndexChanged;
            // 
            // EntriesNotesRichTextBox
            // 
            EntriesNotesRichTextBox.Location = new Point(583, 53);
            EntriesNotesRichTextBox.Name = "EntriesNotesRichTextBox";
            EntriesNotesRichTextBox.Size = new Size(655, 244);
            EntriesNotesRichTextBox.TabIndex = 13;
            EntriesNotesRichTextBox.Text = "";
            // 
            // ChecklistItemNotesRichTextBox
            // 
            ChecklistItemNotesRichTextBox.Location = new Point(583, 366);
            ChecklistItemNotesRichTextBox.Name = "ChecklistItemNotesRichTextBox";
            ChecklistItemNotesRichTextBox.Size = new Size(655, 244);
            ChecklistItemNotesRichTextBox.TabIndex = 14;
            ChecklistItemNotesRichTextBox.Text = "";
            // 
            // AddEntryNoteButton
            // 
            AddEntryNoteButton.Anchor = AnchorStyles.Top;
            AddEntryNoteButton.Location = new Point(1173, 25);
            AddEntryNoteButton.Name = "AddEntryNoteButton";
            AddEntryNoteButton.Size = new Size(65, 25);
            AddEntryNoteButton.TabIndex = 9;
            AddEntryNoteButton.Text = "Edit note";
            AddEntryNoteButton.UseVisualStyleBackColor = true;
            AddEntryNoteButton.Click += AddEntryNoteButton_Click;
            // 
            // MainDailyTasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 627);
            Controls.Add(AddChecklistItemNoteButton);
            Controls.Add(AddEntryNoteButton);
            Controls.Add(ChecklistItemNotesRichTextBox);
            Controls.Add(EntriesNotesRichTextBox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "MainDailyTasksForm";
            Text = "Daily Tasks";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button AddChecklistItemNoteButton;
        private GroupBox groupBox2;
        private Button AddChecklistItemButton;
        private ListBox ChecklistItemsListBox;
        private GroupBox groupBox3;
        private Button AddEntryButton;
        private ListBox EntriesListBox;
        private RichTextBox EntriesNotesRichTextBox;
        private RichTextBox ChecklistItemNotesRichTextBox;
        private Button AddEntryNoteButton;
    }
}
