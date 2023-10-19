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
    public partial class AddNewNote : Form
    {
        public AddNewNote()
        {
            InitializeComponent();
            this.DateNote_Label.Text = $"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToLongDateString()}";
        }
    }
}
