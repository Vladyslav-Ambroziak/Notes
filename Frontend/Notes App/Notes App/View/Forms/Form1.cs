using Notes_App.View.Controls;
using Notes_App.View.Forms;

namespace Notes_App
{
    public partial class Form1 : Form
    {
        int x = 10;
        int y = 10;
        public Form1()
        {
            InitializeComponent();
            ViewAndChangeNote addNewNote = new ViewAndChangeNote();
            addNewNote.Show();
            x += this.menuStrip1.Width;
            for (int i = 0; i < 20; i++)
            {
                PreviewNote note = new PreviewNote();
                note.Location = new Point(x, y);                               
                if (x + note.Width > this.Width - this.menuStrip1.Width)
                {
                    y += note.Height + 10;
                    x = 10 + this.menuStrip1.Width;

                }
                else
                {
                    x += note.Width + 10;
                }
                this.Controls.Add(note);
            }
        }
    }
}