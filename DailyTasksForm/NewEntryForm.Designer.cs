namespace DailyTasksForm
{
    partial class NewEntryForm
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
            entryNameTextBox = new TextBox();
            addNewEntryButton = new Button();
            entryDescriptionTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // entryNameTextBox
            // 
            entryNameTextBox.Location = new Point(12, 27);
            entryNameTextBox.Name = "entryNameTextBox";
            entryNameTextBox.Size = new Size(375, 23);
            entryNameTextBox.TabIndex = 1;
            entryNameTextBox.TextChanged += EntryNameTextBox_TextChanged;
            // 
            // addNewEntryButton
            // 
            addNewEntryButton.Enabled = false;
            addNewEntryButton.Location = new Point(441, 27);
            addNewEntryButton.Name = "addNewEntryButton";
            addNewEntryButton.Size = new Size(124, 23);
            addNewEntryButton.TabIndex = 3;
            addNewEntryButton.Text = "Add Entry";
            addNewEntryButton.UseVisualStyleBackColor = true;
            addNewEntryButton.Click += addNewEntryButton_Click;
            // 
            // entryDescriptionTextBox
            // 
            entryDescriptionTextBox.Location = new Point(12, 56);
            entryDescriptionTextBox.Name = "entryDescriptionTextBox";
            entryDescriptionTextBox.Size = new Size(553, 353);
            entryDescriptionTextBox.TabIndex = 4;
            entryDescriptionTextBox.Text = "";
            // 
            // NewEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 421);
            Controls.Add(entryDescriptionTextBox);
            Controls.Add(addNewEntryButton);
            Controls.Add(entryNameTextBox);
            Name = "NewEntryForm";
            Text = "Add new Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox entryNameTextBox;
        private Button addNewEntryButton;
        private RichTextBox entryDescriptionTextBox;
    }
}