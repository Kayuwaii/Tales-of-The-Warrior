using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Engine;

namespace Tales_of_The_Warrior
{
    public partial class Battle : Form
    {
        private Player BTLplayer;
        private Monster BTLmonster;
        public static bool isWon;
        public Battle()
        {
            InitializeComponent();
        }

        public Battle(Player getPlayerInfo, Monster current) : this()
        {
            BTLplayer = getPlayerInfo;
            BTLmonster = current;


            setBG();
            setEnemyDisplay();
            UpdatePlayerStats();
            UpdateWeaponListInUI();
            UpdatePotionListInUI();
        }

        private void setEnemyDisplay()
        {
            enemyHP.Text = BTLmonster.CurrentHitPoints + "/" + BTLmonster.MaximumHitPoints;
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
        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem inventoryItem in BTLplayer.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        private void UpdatePotionListInUI()
        {
            List<HealingPotion> healingPotions = new List<HealingPotion>();

            foreach (InventoryItem inventoryItem in BTLplayer.Inventory)
            {
                if (inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboPotions.SelectedIndex = 0;
            }
        }
        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            // Get the currently selected weapon from the cboWeapons ComboBox
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            // Determine the amount of damage to do to the monster
            int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            // Apply the damage to the monster's CurrentHitPoints
            BTLmonster.CurrentHitPoints -= damageToMonster;

            // Display message
            rtbMessages.Text += "You hit the " + BTLmonster.Name + " for " + damageToMonster.ToString() + " points." + Environment.NewLine;

            //Update Enemy Display
            setEnemyDisplay();

            // Check if the monster is dead
            if (BTLmonster.CurrentHitPoints <= 0)
            {
                isWon = true;
                // Monster is dead
                if (isWon)
                {
                    MessageBox.Show("You defeated the " + BTLmonster.Name + Environment.NewLine + "You receive " + BTLmonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine  + "You receive " + BTLmonster.RewardGold.ToString() + " gold" + Environment.NewLine);
                }
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You defeated the " + BTLmonster.Name + Environment.NewLine;

                // Give player experience points for killing the monster
                BTLplayer.ExperiencePoints += BTLmonster.RewardExperiencePoints;
                rtbMessages.Text += "You receive " + BTLmonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

                // Give player gold for killing the monster 
                BTLplayer.Gold += BTLmonster.RewardGold;
                rtbMessages.Text += "You receive " + BTLmonster.RewardGold.ToString() + " gold" + Environment.NewLine;

                // Get random loot items from the monster
                List<InventoryItem> lootedItems = new List<InventoryItem>();

                // Add items to the lootedItems list, comparing a random number to the drop percentage
                foreach (LootItem lootItem in BTLmonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                // If no items were randomly selected, then add the default loot item(s).
                if (lootedItems.Count == 0)
                {
                    foreach (LootItem lootItem in BTLmonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                // Add the looted items to the player's inventory
                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    BTLplayer.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                    }
                }

                UpdatePlayerStats();

                UpdateWeaponListInUI();
                UpdatePotionListInUI();
                this.Close();

            }
            else
            {
                // Monster is still alive

                // Determine the amount of damage the monster does to the player
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, BTLmonster.MaximumDamage);

                // Display message
                rtbMessages.Text += "The " + BTLmonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

                // Subtract damage from player
                BTLplayer.CurrentHitPoints -= damageToPlayer;

                // Refresh player data in UI
                lblHitPoints.Text = BTLplayer.CurrentHitPoints.ToString();

                if (BTLplayer.CurrentHitPoints <= 0)
                {
                    isWon = false;
                    // Display message
                    rtbMessages.Text += "The " + BTLmonster.Name + " killed you." + Environment.NewLine;
                    if (!isWon)
                    {
                        MessageBox.Show("The " + BTLmonster.Name + " killed you." + Environment.NewLine);
                    }

                    UpdatePlayerStats();

                    UpdateWeaponListInUI();
                    UpdatePotionListInUI();
                    this.Close();
                }
            }

            ScrollToBottomOfMessages(rtbMessages);
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            // Get the currently selected potion from the combobox
            HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

            // Add healing amount to the player's current hit points
            BTLplayer.CurrentHitPoints = (BTLplayer.CurrentHitPoints + potion.AmountToHeal);

            // CurrentHitPoints cannot exceed player's MaximumHitPoints
            if (BTLplayer.CurrentHitPoints > BTLplayer.MaximumHitPoints)
            {
                BTLplayer.CurrentHitPoints = BTLplayer.MaximumHitPoints;
            }

            // Remove the potion from the player's inventory
            foreach (InventoryItem ii in BTLplayer.Inventory)
            {
                if (ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            // Display message
            rtbMessages.Text += "You drink a " + potion.Name + Environment.NewLine;

            // Monster gets their turn to attack

            // Determine the amount of damage the monster does to the player
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, BTLmonster.MaximumDamage);

            // Display message
            rtbMessages.Text += "The " + BTLmonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

            // Subtract damage from player
            BTLplayer.CurrentHitPoints -= damageToPlayer;

            if (BTLplayer.CurrentHitPoints <= 0)
            {
                // Display message
                rtbMessages.Text += "The " + BTLmonster.Name + " killed you." + Environment.NewLine;

            }

            // Refresh player data in UI
            lblHitPoints.Text = BTLplayer.CurrentHitPoints.ToString();

            UpdatePotionListInUI();

            ScrollToBottomOfMessages(rtbMessages);
        }

        public static void ScrollToBottomOfMessages(RichTextBox box)
        {
            box.SelectionStart = box.Text.Length;
            box.ScrollToCaret();
        }
        private void setBG()
        {
            Image myimage = new Bitmap(@".\battleBG\" + BTLplayer.CurrentLocation.ID + ".jpg");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Battle_Load(object sender, EventArgs e)
        {

        }
    }

}
