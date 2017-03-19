namespace Tales_of_The_Warrior
{
    partial class Battle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enemyHP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSap = new System.Windows.Forms.Label();
            this.btnUseScroll = new System.Windows.Forms.Button();
            this.cboScrolls = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(104, 110);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(35, 13);
            this.lblLevel.TabIndex = 15;
            this.lblLevel.Text = "label8";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(104, 84);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(35, 13);
            this.lblExperience.TabIndex = 14;
            this.lblExperience.Text = "label7";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(104, 56);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(35, 13);
            this.lblGold.TabIndex = 13;
            this.lblGold.Text = "label6";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(104, 30);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(35, 13);
            this.lblHitPoints.TabIndex = 12;
            this.lblHitPoints.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Experience:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hit Points:";
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(546, 286);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 21;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(546, 252);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 20;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // cboPotions
            // 
            this.cboPotions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboPotions.Location = new System.Drawing.Point(295, 286);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(78, 21);
            this.cboPotions.TabIndex = 19;
            // 
            // cboWeapons
            // 
            this.cboWeapons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboWeapons.Location = new System.Drawing.Point(295, 252);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(78, 21);
            this.cboWeapons.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select Action:";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(145, 12);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(346, 201);
            this.rtbMessages.TabIndex = 22;
            this.rtbMessages.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Enemy HP: ";
            // 
            // enemyHP
            // 
            this.enemyHP.AutoSize = true;
            this.enemyHP.Location = new System.Drawing.Point(566, 31);
            this.enemyHP.Name = "enemyHP";
            this.enemyHP.Size = new System.Drawing.Size(63, 13);
            this.enemyHP.TabIndex = 24;
            this.enemyHP.Text = "Enemy HP: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "SAP:";
            // 
            // lblSap
            // 
            this.lblSap.AutoSize = true;
            this.lblSap.Location = new System.Drawing.Point(104, 137);
            this.lblSap.Name = "lblSap";
            this.lblSap.Size = new System.Drawing.Size(35, 13);
            this.lblSap.TabIndex = 26;
            this.lblSap.Text = "label8";
            // 
            // btnUseScroll
            // 
            this.btnUseScroll.Location = new System.Drawing.Point(546, 317);
            this.btnUseScroll.Name = "btnUseScroll";
            this.btnUseScroll.Size = new System.Drawing.Size(75, 23);
            this.btnUseScroll.TabIndex = 28;
            this.btnUseScroll.Text = "Use";
            this.btnUseScroll.UseVisualStyleBackColor = true;
            // 
            // cboScrolls
            // 
            this.cboScrolls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScrolls.FormattingEnabled = true;
            this.cboScrolls.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboScrolls.Location = new System.Drawing.Point(295, 317);
            this.cboScrolls.Name = "cboScrolls";
            this.cboScrolls.Size = new System.Drawing.Size(78, 21);
            this.cboScrolls.TabIndex = 27;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 350);
            this.Controls.Add(this.btnUseScroll);
            this.Controls.Add(this.cboScrolls);
            this.Controls.Add(this.lblSap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enemyHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Battle";
            this.Text = "Battle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Battle_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label enemyHP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSap;
        private System.Windows.Forms.Button btnUseScroll;
        private System.Windows.Forms.ComboBox cboScrolls;
    }
}