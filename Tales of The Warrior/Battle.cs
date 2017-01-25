using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tales_of_The_Warrior;
using Engine;

namespace Tales_of_The_Warrior
{
    public partial class Battle : Form
    {
        private Player BTLplayer;
        public Battle()
        {
            InitializeComponent();
        }

        public Battle(Player getPlayerInfo) : this()
        {
            BTLplayer = getPlayerInfo;
            UpdatePlayerStats();
        }
        public void UpdatePlayerStats()
        {
            if (BTLplayer.Level < 1)
            {
                BTLplayer.Level++;
            }
            if (BTLplayer.ExperiencePoints >= BTLplayer.ExperiencePointsNeeded)
            {
                BTLplayer.lvlUp();
            }

            // Refresh player information and inventory controls
            lblHitPoints.Text = BTLplayer.CurrentHitPoints.ToString();
            lblGold.Text = BTLplayer.Gold.ToString();
            lblExperience.Text = BTLplayer.ExperiencePoints.ToString();
            lblLevel.Text = BTLplayer.Level.ToString();

        }
    }

}
