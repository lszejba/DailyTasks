namespace DailyTasksForm
{
    partial class NewNoteForm
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
            AddNoteButton = new Button();
            NoteTextBox = new TextBox();
            SuspendLayout();
            // 
            // ParentNameLabel
            // 
            ParentNameLabel.AutoSize = true;
            ParentNameLabel.Location = new Point(9, 9);
            ParentNameLabel.Name = "ParentNameLabel";
            ParentNameLabel.Size = new Size(0, 15);
            ParentNameLabel.TabIndex = 0;
            // 
            // AddNoteButton
            // 
            AddNoteButton.Enabled = false;
            AddNoteButton.Location = new Point(428, 27);
            AddNoteButton.Name = "AddNoteButton";
            AddNoteButton.Size = new Size(98, 23);
            AddNoteButton.TabIndex = 1;
            AddNoteButton.Text = "Add Note";
            AddNoteButton.UseVisualStyleBackColor = true;
            AddNoteButton.Click += AddNoteButton_Click;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(9, 27);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(413, 23);
            NoteTextBox.TabIndex = 2;
            NoteTextBox.TextChanged += NodeTextBox_TextChanged;
            // 
            // NewNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 70);
            Controls.Add(NoteTextBox);
            Controls.Add(AddNoteButton);
            Controls.Add(ParentNameLabel);
            Name = "NewNoteForm";
            Text = "Add new note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ParentNameLabel;
        private Button AddNoteButton;
        private TextBox NoteTextBox;
    }
}