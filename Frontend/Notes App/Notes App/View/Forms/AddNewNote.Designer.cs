namespace Notes_App.View.Forms
{
    partial class AddNewNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewNote));
            Title_TextBox = new TextBox();
            Text_TextBox = new TextBox();
            DateNote_Label = new Label();
            Ok_Button = new Button();
            Cancel_Button = new Button();
            SuspendLayout();
            // 
            // Title_TextBox
            // 
            Title_TextBox.BackColor = Color.FromArgb(242, 217, 116);
            Title_TextBox.BorderStyle = BorderStyle.FixedSingle;
            Title_TextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Title_TextBox.ForeColor = Color.FromArgb(83, 78, 82);
            Title_TextBox.Location = new Point(12, 12);
            Title_TextBox.Multiline = true;
            Title_TextBox.Name = "Title_TextBox";
            Title_TextBox.Size = new Size(304, 64);
            Title_TextBox.TabIndex = 0;
            Title_TextBox.Text = "Title";
            // 
            // Text_TextBox
            // 
            Text_TextBox.BackColor = Color.FromArgb(242, 217, 116);
            Text_TextBox.BorderStyle = BorderStyle.FixedSingle;
            Text_TextBox.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Text_TextBox.ForeColor = Color.FromArgb(83, 78, 82);
            Text_TextBox.Location = new Point(12, 91);
            Text_TextBox.Multiline = true;
            Text_TextBox.Name = "Text_TextBox";
            Text_TextBox.Size = new Size(304, 205);
            Text_TextBox.TabIndex = 1;
            Text_TextBox.Text = "Text";
            // 
            // DateNote_Label
            // 
            DateNote_Label.AutoSize = true;
            DateNote_Label.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DateNote_Label.ForeColor = Color.FromArgb(242, 217, 116);
            DateNote_Label.Location = new Point(28, 313);
            DateNote_Label.Name = "DateNote_Label";
            DateNote_Label.Size = new Size(55, 18);
            DateNote_Label.TabIndex = 2;
            DateNote_Label.Text = "label1";
            // 
            // Ok_Button
            // 
            Ok_Button.BackColor = Color.FromArgb(242, 217, 116);
            Ok_Button.FlatStyle = FlatStyle.Flat;
            Ok_Button.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Ok_Button.ForeColor = Color.FromArgb(83, 78, 82);
            Ok_Button.Location = new Point(10, 346);
            Ok_Button.Name = "Ok_Button";
            Ok_Button.Size = new Size(150, 27);
            Ok_Button.TabIndex = 3;
            Ok_Button.Text = "OK";
            Ok_Button.UseVisualStyleBackColor = false;
            // 
            // Cancel_Button
            // 
            Cancel_Button.BackColor = Color.FromArgb(242, 217, 116);
            Cancel_Button.FlatStyle = FlatStyle.Flat;
            Cancel_Button.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel_Button.ForeColor = Color.FromArgb(83, 78, 82);
            Cancel_Button.Location = new Point(166, 346);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(150, 27);
            Cancel_Button.TabIndex = 4;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = false;
            // 
            // AddNewNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 93, 98);
            ClientSize = new Size(328, 384);
            Controls.Add(Cancel_Button);
            Controls.Add(Ok_Button);
            Controls.Add(DateNote_Label);
            Controls.Add(Text_TextBox);
            Controls.Add(Title_TextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewNote";
            Text = "Add new note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title_TextBox;
        private TextBox Text_TextBox;
        private Label DateNote_Label;
        private Button Ok_Button;
        private Button Cancel_Button;
    }
}