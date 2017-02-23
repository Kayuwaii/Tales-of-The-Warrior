using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tales_of_The_Warrior
{
    public partial class LAUNCHER : Form
    {
        string str = null;
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
            str = b.Text;
            b.Text = "⦕ " + str + "⦖ ";
        }

        private void SelMouseLeave(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = str;
        }

        private void play_click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Oooops!, The Game Has Suddenly suffered a downgrade!" + Environment.NewLine + "ErrorCode= Devs.ARE(LAZY)");
            var game = new TalesOfTheWarrior();
            game.Show();
            this.Dispose();
            cleanMem();
        }

        public static void cleanMem()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btn_exit_MouseClick(object sender, EventArgs e)
        {
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Application.Exit();
        }
    }
}
