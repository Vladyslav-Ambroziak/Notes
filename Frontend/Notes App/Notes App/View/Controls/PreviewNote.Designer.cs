namespace Notes_App.View.Controls
{
    partial class PreviewNote
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            viewAllToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            TextNote_TextBox = new TextBox();
            DateNote_Label = new Label();
            TitleNote_TextBox = new TextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 217, 116);
            button1.ContextMenuStrip = contextMenuStrip1;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(173, 6);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 0, 8);
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = ". . .";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(83, 78, 82);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewAllToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // viewAllToolStripMenuItem
            // 
            viewAllToolStripMenuItem.BackColor = Color.FromArgb(242, 217, 116);
            viewAllToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewAllToolStripMenuItem.ForeColor = Color.FromArgb(150, 93, 98);
            viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            viewAllToolStripMenuItem.Size = new Size(117, 22);
            viewAllToolStripMenuItem.Text = "View all";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = Color.FromArgb(242, 217, 116);
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(150, 93, 98);
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(117, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // TextNote_TextBox
            // 
            TextNote_TextBox.BackColor = Color.FromArgb(242, 217, 116);
            TextNote_TextBox.BorderStyle = BorderStyle.FixedSingle;
            TextNote_TextBox.Enabled = false;
            TextNote_TextBox.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextNote_TextBox.ForeColor = Color.FromArgb(83, 78, 82);
            TextNote_TextBox.Location = new Point(6, 52);
            TextNote_TextBox.Multiline = true;
            TextNote_TextBox.Name = "TextNote_TextBox";
            TextNote_TextBox.Size = new Size(207, 161);
            TextNote_TextBox.TabIndex = 0;
            // 
            // DateNote_Label
            // 
            DateNote_Label.AutoSize = true;
            DateNote_Label.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DateNote_Label.ForeColor = Color.FromArgb(242, 217, 116);
            DateNote_Label.Location = new Point(6, 225);
            DateNote_Label.Name = "DateNote_Label";
            DateNote_Label.Size = new Size(48, 14);
            DateNote_Label.TabIndex = 3;
            DateNote_Label.Text = "label1";
            // 
            // TitleNote_TextBox
            // 
            TitleNote_TextBox.BackColor = Color.FromArgb(242, 217, 116);
            TitleNote_TextBox.BorderStyle = BorderStyle.FixedSingle;
            TitleNote_TextBox.Enabled = false;
            TitleNote_TextBox.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TitleNote_TextBox.ForeColor = Color.FromArgb(83, 78, 82);
            TitleNote_TextBox.Location = new Point(6, 6);
            TitleNote_TextBox.Multiline = true;
            TitleNote_TextBox.Name = "TitleNote_TextBox";
            TitleNote_TextBox.Size = new Size(161, 40);
            TitleNote_TextBox.TabIndex = 0;
            // 
            // PreviewNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 93, 98);
            Controls.Add(TitleNote_TextBox);
            Controls.Add(TextNote_TextBox);
            Controls.Add(DateNote_Label);
            Controls.Add(button1);
            Name = "PreviewNote";
            Size = new Size(218, 253);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label DateNote_Label;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewAllToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TextBox TextNote_TextBox;
        private TextBox TitleNote_TextBox;
    }
}
