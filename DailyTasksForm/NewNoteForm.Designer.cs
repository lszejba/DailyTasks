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
            EditNoteButton = new Button();
            NoteRTFBox = new RichTextBox();
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
            EditNoteButton.Enabled = false;
            EditNoteButton.Location = new Point(429, 12);
            EditNoteButton.Name = "AddNoteButton";
            EditNoteButton.Size = new Size(98, 23);
            EditNoteButton.TabIndex = 1;
            EditNoteButton.Text = "Save note";
            EditNoteButton.UseVisualStyleBackColor = true;
            EditNoteButton.Click += EditNoteButton_Click;
            // 
            // NoteRTFBox
            // 
            NoteRTFBox.Location = new Point(9, 12);
            NoteRTFBox.Name = "NoteRTFBox";
            NoteRTFBox.Size = new Size(413, 103);
            NoteRTFBox.TabIndex = 3;
            NoteRTFBox.Text = "";
            NoteRTFBox.TextChanged += NoteRTFBox_TextChanged;
            // 
            // NewNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 127);
            Controls.Add(NoteRTFBox);
            Controls.Add(EditNoteButton);
            Controls.Add(ParentNameLabel);
            Name = "NewNoteForm";
            Text = "Edit note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ParentNameLabel;
        private Button EditNoteButton;
        private RichTextBox NoteRTFBox;
    }
}