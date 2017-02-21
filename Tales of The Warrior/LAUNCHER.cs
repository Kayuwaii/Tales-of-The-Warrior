using System.Drawing;
using System.Windows.Forms;

namespace Tales_of_The_Warrior
{
    public partial class LAUNCHER : Form
    {
        public LAUNCHER()
        {
            InitializeComponent();
            btn_play.Parent = pictureBox1;
            btn_play.BackColor = Color.Transparent;
            btn_exit.Parent = pictureBox1;
            btn_exit.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void SelMouseEnter(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            b.Text += "{";
        }

        private void SelMouseLeave(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = b.Text.TrimEnd('{');
        }
    }
}
