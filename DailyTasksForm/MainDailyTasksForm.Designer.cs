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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDailyTasksForm));
            label1 = new Label();
            groupBox2 = new GroupBox();
            AddChecklistItemButton = new Button();
            ChecklistItemsListBox = new ListBox();
            groupBox3 = new GroupBox();
            AddEntryButton = new Button();
            EntriesListBox = new ListBox();
            EntriesNotesRichTextBox = new RichTextBox();
            ChecklistItemNotesRichTextBox = new RichTextBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(AddChecklistItemButton);
            groupBox2.Controls.Add(ChecklistItemsListBox);
            groupBox2.Location = new Point(6, 442);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(666, 514);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Checklist Items";
            // 
            // AddChecklistItemButton
            // 
            AddChecklistItemButton.Anchor = AnchorStyles.Top;
            AddChecklistItemButton.Location = new Point(635, 0);
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
            ChecklistItemsListBox.BackColor = Color.Silver;
            ChecklistItemsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            ChecklistItemsListBox.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ChecklistItemsListBox.FormattingEnabled = true;
            ChecklistItemsListBox.ItemHeight = 18;
            ChecklistItemsListBox.Location = new Point(38, 32);
            ChecklistItemsListBox.Name = "ChecklistItemsListBox";
            ChecklistItemsListBox.Size = new Size(622, 454);
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
            groupBox3.Size = new Size(669, 413);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Entries";
            // 
            // AddEntryButton
            // 
            AddEntryButton.Anchor = AnchorStyles.Top;
            AddEntryButton.Location = new Point(635, 0);
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
            EntriesListBox.BackColor = Color.Silver;
            EntriesListBox.DrawMode = DrawMode.OwnerDrawFixed;
            EntriesListBox.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            EntriesListBox.FormattingEnabled = true;
            EntriesListBox.ItemHeight = 20;
            EntriesListBox.Location = new Point(3, 30);
            EntriesListBox.Name = "EntriesListBox";
            EntriesListBox.Size = new Size(663, 364);
            EntriesListBox.TabIndex = 6;
            EntriesListBox.DrawItem += EntriesListBox_DrawItem;
            EntriesListBox.SelectedIndexChanged += EntriesListBox_SelectedIndexChanged;
            // 
            // EntriesNotesRichTextBox
            // 
            EntriesNotesRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EntriesNotesRichTextBox.Location = new Point(681, 56);
            EntriesNotesRichTextBox.Name = "EntriesNotesRichTextBox";
            EntriesNotesRichTextBox.Size = new Size(1211, 380);
            EntriesNotesRichTextBox.TabIndex = 13;
            EntriesNotesRichTextBox.Text = "";
            EntriesNotesRichTextBox.TextChanged += RichTextBox_TextChanged;
            // 
            // ChecklistItemNotesRichTextBox
            // 
            ChecklistItemNotesRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ChecklistItemNotesRichTextBox.Location = new Point(681, 474);
            ChecklistItemNotesRichTextBox.Name = "ChecklistItemNotesRichTextBox";
            ChecklistItemNotesRichTextBox.Size = new Size(1211, 482);
            ChecklistItemNotesRichTextBox.TabIndex = 14;
            ChecklistItemNotesRichTextBox.Text = "";
            ChecklistItemNotesRichTextBox.TextChanged += RichTextBox_TextChanged;
            // 
            // MainDailyTasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 961);
            Controls.Add(ChecklistItemNotesRichTextBox);
            Controls.Add(EntriesNotesRichTextBox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainDailyTasksForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daily Tasks";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox2;
        private Button AddChecklistItemButton;
        private ListBox ChecklistItemsListBox;
        private GroupBox groupBox3;
        private Button AddEntryButton;
        private ListBox EntriesListBox;
        private RichTextBox EntriesNotesRichTextBox;
        private RichTextBox ChecklistItemNotesRichTextBox;
    }
}
