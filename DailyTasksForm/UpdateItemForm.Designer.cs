namespace DailyTasksForm
{
    partial class UpdateItemForm
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
            itemNameLabel = new Label();
            itemNoteLabel = new Label();
            itemNameTextBox = new TextBox();
            itemNoteTextBox = new RichTextBox();
            saveItemEditButton = new Button();
            SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(12, 24);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(39, 15);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Name";
            // 
            // itemNoteLabel
            // 
            itemNoteLabel.AutoSize = true;
            itemNoteLabel.Location = new Point(18, 59);
            itemNoteLabel.Name = "itemNoteLabel";
            itemNoteLabel.Size = new Size(33, 15);
            itemNoteLabel.TabIndex = 1;
            itemNoteLabel.Text = "Note";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(57, 21);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(435, 23);
            itemNameTextBox.TabIndex = 2;
            // 
            // itemNoteTextBox
            // 
            itemNoteTextBox.Location = new Point(57, 56);
            itemNoteTextBox.Name = "itemNoteTextBox";
            itemNoteTextBox.Size = new Size(516, 257);
            itemNoteTextBox.TabIndex = 3;
            itemNoteTextBox.Text = "";
            // 
            // saveItemEditButton
            // 
            saveItemEditButton.Location = new Point(498, 12);
            saveItemEditButton.Name = "saveItemEditButton";
            saveItemEditButton.Size = new Size(75, 38);
            saveItemEditButton.TabIndex = 4;
            saveItemEditButton.Text = "Save Changes";
            saveItemEditButton.UseVisualStyleBackColor = true;
            saveItemEditButton.Click += saveItemEditButton_Click;
            // 
            // UpdateItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 328);
            Controls.Add(saveItemEditButton);
            Controls.Add(itemNoteTextBox);
            Controls.Add(itemNameTextBox);
            Controls.Add(itemNoteLabel);
            Controls.Add(itemNameLabel);
            Name = "UpdateItemForm";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemNameLabel;
        private Label itemNoteLabel;
        private TextBox itemNameTextBox;
        private RichTextBox itemNoteTextBox;
        private Button saveItemEditButton;
    }
}