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
            AddNewChecklistItemButton = new Button();
            newItemsGridView = new DataGridView();
            gridItemName = new DataGridViewTextBoxColumn();
            gridItemNote = new DataGridViewTextBoxColumn();
            firstAsParentCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)newItemsGridView).BeginInit();
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
            // AddNewChecklistItemButton
            // 
            AddNewChecklistItemButton.Location = new Point(429, 12);
            AddNewChecklistItemButton.Name = "AddNewChecklistItemButton";
            AddNewChecklistItemButton.Size = new Size(128, 38);
            AddNewChecklistItemButton.TabIndex = 2;
            AddNewChecklistItemButton.Text = "Add Item(s)";
            AddNewChecklistItemButton.UseVisualStyleBackColor = true;
            AddNewChecklistItemButton.Click += AddNewChecklistItemButton_Click;
            // 
            // newItemsGridView
            // 
            newItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            newItemsGridView.Columns.AddRange(new DataGridViewColumn[] { gridItemName, gridItemNote });
            newItemsGridView.Location = new Point(14, 56);
            newItemsGridView.Name = "newItemsGridView";
            newItemsGridView.Size = new Size(543, 251);
            newItemsGridView.TabIndex = 4;
            // 
            // gridItemName
            // 
            gridItemName.HeaderText = "Name";
            gridItemName.Name = "gridItemName";
            gridItemName.Width = 200;
            // 
            // gridItemNote
            // 
            gridItemNote.HeaderText = "Note";
            gridItemNote.Name = "gridItemNote";
            gridItemNote.Width = 300;
            // 
            // firstAsParentCheckBox
            // 
            firstAsParentCheckBox.AutoSize = true;
            firstAsParentCheckBox.Location = new Point(12, 313);
            firstAsParentCheckBox.Name = "firstAsParentCheckBox";
            firstAsParentCheckBox.Size = new Size(155, 19);
            firstAsParentCheckBox.TabIndex = 5;
            firstAsParentCheckBox.Text = "Treat First Item as Parent";
            firstAsParentCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewChecklistItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 336);
            Controls.Add(firstAsParentCheckBox);
            Controls.Add(newItemsGridView);
            Controls.Add(AddNewChecklistItemButton);
            Controls.Add(ParentNameLabel);
            StartPosition = FormStartPosition.CenterParent;
            Name = "NewChecklistItemForm";
            Text = "New Checklist Item(s)";
            ((System.ComponentModel.ISupportInitialize)newItemsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ParentNameLabel;
        private Button AddNewChecklistItemButton;
        private DataGridView newItemsGridView;
        private DataGridViewTextBoxColumn gridItemName;
        private DataGridViewTextBoxColumn gridItemNote;
        private CheckBox firstAsParentCheckBox;
    }
}