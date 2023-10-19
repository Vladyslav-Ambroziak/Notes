using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_App.View.Forms
{
    public partial class ViewAndChangeNote : Form
    {
        public ViewAndChangeNote()
        {
            InitializeComponent();
        }

        private void CorrectNote_Button_Click(object sender, EventArgs e)
        {
            this.CorrectNote_Button.Visible = false;
            this.Save_Button.Visible = true;
            this.Cancel_Button.Visible = true;
            this.Title_TextBox.Enabled = true;
            this.Text_TextBox.Enabled = true;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            this.CorrectNote_Button.Visible = true;
            this.Save_Button.Visible = false;
            this.Cancel_Button.Visible = false;
            this.Title_TextBox.Enabled = false;
            this.Text_TextBox.Enabled = false;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.CorrectNote_Button.Visible = true;
            this.Save_Button.Visible = false;
            this.Cancel_Button.Visible = false;
            this.Title_TextBox.Enabled = false;
            this.Text_TextBox.Enabled = false;
        }
    }
}
