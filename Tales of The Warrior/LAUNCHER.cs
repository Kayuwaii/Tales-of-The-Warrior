using System.Drawing;
using System.Windows.Forms;

namespace Tales_of_The_Warrior
{
    public partial class LAUNCHER : Form
    {
        public LAUNCHER()
        {
            InitializeComponent();
            button1.Parent = pictureBox1;
            button1.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
        }
    }
}
