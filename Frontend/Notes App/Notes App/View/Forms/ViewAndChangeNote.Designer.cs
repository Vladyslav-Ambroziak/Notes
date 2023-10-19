namespace Notes_App.View.Forms
{
    partial class ViewAndChangeNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAndChangeNote));
            DateNote_Label = new Label();
            Text_TextBox = new TextBox();
            Title_TextBox = new TextBox();
            CorrectNote_Button = new Button();
            Cancel_Button = new Button();
            Save_Button = new Button();
            SuspendLayout();
            // 
            // DateNote_Label
            // 
            DateNote_Label.AutoSize = true;
            DateNote_Label.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DateNote_Label.ForeColor = Color.FromArgb(242, 217, 116);
            DateNote_Label.Location = new Point(28, 313);
            DateNote_Label.Name = "DateNote_Label";
            DateNote_Label.Size = new Size(55, 18);
            DateNote_Label.TabIndex = 5;
            DateNote_Label.Text = "label1";
            // 
            // Text_TextBox
            // 
            Text_TextBox.BackColor = Color.FromArgb(242, 217, 116);
            Text_TextBox.BorderStyle = BorderStyle.FixedSingle;
            Text_TextBox.Enabled = false;
            Text_TextBox.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Text_TextBox.ForeColor = Color.FromArgb(83, 78, 82);
            Text_TextBox.Location = new Point(12, 91);
            Text_TextBox.Multiline = true;
            Text_TextBox.Name = "Text_TextBox";
            Text_TextBox.Size = new Size(306, 205);
            Text_TextBox.TabIndex = 4;
            Text_TextBox.Text = "Text";
            // 
            // Title_TextBox
            // 
            Title_TextBox.BackColor = Color.FromArgb(242, 217, 116);
            Title_TextBox.BorderStyle = BorderStyle.FixedSingle;
            Title_TextBox.Enabled = false;
            Title_TextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Title_TextBox.ForeColor = Color.FromArgb(83, 78, 82);
            Title_TextBox.Location = new Point(12, 12);
            Title_TextBox.Multiline = true;
            Title_TextBox.Name = "Title_TextBox";
            Title_TextBox.Size = new Size(306, 64);
            Title_TextBox.TabIndex = 3;
            Title_TextBox.Text = "Title";
            // 
            // CorrectNote_Button
            // 
            CorrectNote_Button.BackColor = Color.FromArgb(242, 217, 116);
            CorrectNote_Button.FlatStyle = FlatStyle.Flat;
            CorrectNote_Button.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CorrectNote_Button.ForeColor = Color.FromArgb(83, 78, 82);
            CorrectNote_Button.Location = new Point(89, 348);
            CorrectNote_Button.Name = "CorrectNote_Button";
            CorrectNote_Button.Size = new Size(150, 27);
            CorrectNote_Button.TabIndex = 6;
            CorrectNote_Button.Text = "Correct note";
            CorrectNote_Button.UseVisualStyleBackColor = false;
            CorrectNote_Button.Click += CorrectNote_Button_Click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.BackColor = Color.FromArgb(242, 217, 116);
            Cancel_Button.FlatStyle = FlatStyle.Flat;
            Cancel_Button.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel_Button.ForeColor = Color.FromArgb(83, 78, 82);
            Cancel_Button.Location = new Point(168, 347);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(150, 27);
            Cancel_Button.TabIndex = 8;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = false;
            Cancel_Button.Visible = false;
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // Save_Button
            // 
            Save_Button.BackColor = Color.FromArgb(242, 217, 116);
            Save_Button.FlatStyle = FlatStyle.Flat;
            Save_Button.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Save_Button.ForeColor = Color.FromArgb(83, 78, 82);
            Save_Button.Location = new Point(12, 347);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(150, 27);
            Save_Button.TabIndex = 7;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Visible = false;
            Save_Button.Click += Save_Button_Click;
            // 
            // ViewAndChangeNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 93, 98);
            ClientSize = new Size(330, 386);
            Controls.Add(Cancel_Button);
            Controls.Add(Save_Button);
            Controls.Add(CorrectNote_Button);
            Controls.Add(DateNote_Label);
            Controls.Add(Text_TextBox);
            Controls.Add(Title_TextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewAndChangeNote";
            Text = "Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateNote_Label;
        private TextBox Text_TextBox;
        private TextBox Title_TextBox;
        private Button CorrectNote_Button;
        private Button Cancel_Button;
        private Button Save_Button;
    }
}