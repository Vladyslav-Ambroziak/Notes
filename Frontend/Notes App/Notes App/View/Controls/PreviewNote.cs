using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_App.View.Controls
{
    public partial class PreviewNote : UserControl
    {
        public PreviewNote()
        {
            InitializeComponent();
            this.DateNote_Label.Text = $"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToLongDateString()}";
            this.TitleNote_TextBox.Text = "Main Title";
            this.TextNote_TextBox.Text = "oshgsohsoehgo sorrhgsiehg sepihg geiehgpih gewihgie ehigpws";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
