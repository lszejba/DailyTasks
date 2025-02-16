namespace DailyTasksForm
{
    partial class NewChecklistItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ParentNameLabel = new Label();
            ChecklistItemNameTextBox = new TextBox();
            AddNewChecklistItemButton = new Button();
            SuspendLayout();
            // 
            // ParentNameLabel
            // 
            ParentNameLabel.AutoSize = true;
            ParentNameLabel.Location = new Point(12, 9);
            ParentNameLabel.Name = "ParentNameLabel";
            ParentNameLabel.Size = new Size(0, 15);
            ParentNameLabel.TabIndex = 0;
            // 
            // ChecklistItemNameTextBox
            // 
            ChecklistItemNameTextBox.Location = new Point(12, 27);
            ChecklistItemNameTextBox.Name = "ChecklistItemNameTextBox";
            ChecklistItemNameTextBox.Size = new Size(441, 23);
            ChecklistItemNameTextBox.TabIndex = 1;
            ChecklistItemNameTextBox.TextChanged += ChecklistNameTextBox_TextChanged;
            // 
            // AddNewChecklistItemButton
            // 
            AddNewChecklistItemButton.Enabled = false;
            AddNewChecklistItemButton.Location = new Point(459, 27);
            AddNewChecklistItemButton.Name = "AddNewChecklistItemButton";
            AddNewChecklistItemButton.Size = new Size(128, 23);
            AddNewChecklistItemButton.TabIndex = 2;
            AddNewChecklistItemButton.Text = "Add Item";
            AddNewChecklistItemButton.UseVisualStyleBackColor = true;
            AddNewChecklistItemButton.Click += AddNewChecklistItemButton_Click;
            // 
            // NewChecklistItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 68);
            Controls.Add(AddNewChecklistItemButton);
            Controls.Add(ChecklistItemNameTextBox);
            Controls.Add(ParentNameLabel);
            Name = "NewChecklistItemForm";
            Text = "New Checklist Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ParentNameLabel;
        private TextBox ChecklistItemNameTextBox;
        private Button AddNewChecklistItemButton;
    }
}