namespace TheQuest
{
    partial class Form1
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
            this.picBow = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picGhoul = new System.Windows.Forms.PictureBox();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.picPotionRed = new System.Windows.Forms.PictureBox();
            this.picPotionBlue = new System.Windows.Forms.PictureBox();
            this.picBat = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picMace = new System.Windows.Forms.PictureBox();
            this.picInventoryBow = new System.Windows.Forms.PictureBox();
            this.picInventoryPotionBlue = new System.Windows.Forms.PictureBox();
            this.picInventorySword = new System.Windows.Forms.PictureBox();
            this.picInventoryMace = new System.Windows.Forms.PictureBox();
            this.picInventoryPotionRed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBatHP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGhostHP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGhoulHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPotionBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPotionRed)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBow
            // 
            this.picBow.BackColor = System.Drawing.Color.Transparent;
            this.picBow.Image = global::TheQuest.Properties.Resources.bow;
            this.picBow.Location = new System.Drawing.Point(150, 58);
            this.picBow.Name = "picBow";
            this.picBow.Size = new System.Drawing.Size(30, 30);
            this.picBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBow.TabIndex = 0;
            this.picBow.TabStop = false;
            this.picBow.Visible = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = global::TheQuest.Properties.Resources.player;
            this.picPlayer.Location = new System.Drawing.Point(78, 58);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(30, 30);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            this.picPlayer.Visible = false;
            // 
            // picGhoul
            // 
            this.picGhoul.BackColor = System.Drawing.Color.Transparent;
            this.picGhoul.Image = global::TheQuest.Properties.Resources.ghoul;
            this.picGhoul.Location = new System.Drawing.Point(258, 58);
            this.picGhoul.Name = "picGhoul";
            this.picGhoul.Size = new System.Drawing.Size(30, 30);
            this.picGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhoul.TabIndex = 2;
            this.picGhoul.TabStop = false;
            this.picGhoul.Visible = false;
            // 
            // picGhost
            // 
            this.picGhost.BackColor = System.Drawing.Color.Transparent;
            this.picGhost.Image = global::TheQuest.Properties.Resources.ghost;
            this.picGhost.Location = new System.Drawing.Point(294, 58);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(30, 30);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhost.TabIndex = 3;
            this.picGhost.TabStop = false;
            this.picGhost.Visible = false;
            // 
            // picPotionRed
            // 
            this.picPotionRed.BackColor = System.Drawing.Color.Transparent;
            this.picPotionRed.Image = global::TheQuest.Properties.Resources.potion_red;
            this.picPotionRed.Location = new System.Drawing.Point(366, 58);
            this.picPotionRed.Name = "picPotionRed";
            this.picPotionRed.Size = new System.Drawing.Size(30, 30);
            this.picPotionRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPotionRed.TabIndex = 4;
            this.picPotionRed.TabStop = false;
            this.picPotionRed.Visible = false;
            // 
            // picPotionBlue
            // 
            this.picPotionBlue.BackColor = System.Drawing.Color.Transparent;
            this.picPotionBlue.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.picPotionBlue.Location = new System.Drawing.Point(330, 58);
            this.picPotionBlue.Name = "picPotionBlue";
            this.picPotionBlue.Size = new System.Drawing.Size(30, 30);
            this.picPotionBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPotionBlue.TabIndex = 5;
            this.picPotionBlue.TabStop = false;
            this.picPotionBlue.Visible = false;
            // 
            // picBat
            // 
            this.picBat.BackColor = System.Drawing.Color.Transparent;
            this.picBat.Image = global::TheQuest.Properties.Resources.bat;
            this.picBat.Location = new System.Drawing.Point(222, 58);
            this.picBat.Name = "picBat";
            this.picBat.Size = new System.Drawing.Size(30, 30);
            this.picBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBat.TabIndex = 6;
            this.picBat.TabStop = false;
            this.picBat.Visible = false;
            // 
            // picSword
            // 
            this.picSword.BackColor = System.Drawing.Color.Transparent;
            this.picSword.Image = global::TheQuest.Properties.Resources.sword;
            this.picSword.Location = new System.Drawing.Point(114, 58);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(30, 30);
            this.picSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSword.TabIndex = 7;
            this.picSword.TabStop = false;
            this.picSword.Visible = false;
            // 
            // picMace
            // 
            this.picMace.BackColor = System.Drawing.Color.Transparent;
            this.picMace.Image = global::TheQuest.Properties.Resources.mace;
            this.picMace.Location = new System.Drawing.Point(186, 58);
            this.picMace.Name = "picMace";
            this.picMace.Size = new System.Drawing.Size(30, 30);
            this.picMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMace.TabIndex = 8;
            this.picMace.TabStop = false;
            this.picMace.Visible = false;
            // 
            // picInventoryBow
            // 
            this.picInventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryBow.Image = global::TheQuest.Properties.Resources.bow;
            this.picInventoryBow.Location = new System.Drawing.Point(190, 319);
            this.picInventoryBow.Name = "picInventoryBow";
            this.picInventoryBow.Size = new System.Drawing.Size(50, 50);
            this.picInventoryBow.TabIndex = 9;
            this.picInventoryBow.TabStop = false;
            this.picInventoryBow.Visible = false;
            this.picInventoryBow.Click += new System.EventHandler(this.picInventoryBow_Click);
            // 
            // picInventoryPotionBlue
            // 
            this.picInventoryPotionBlue.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryPotionBlue.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.picInventoryPotionBlue.Location = new System.Drawing.Point(134, 319);
            this.picInventoryPotionBlue.Name = "picInventoryPotionBlue";
            this.picInventoryPotionBlue.Size = new System.Drawing.Size(50, 50);
            this.picInventoryPotionBlue.TabIndex = 11;
            this.picInventoryPotionBlue.TabStop = false;
            this.picInventoryPotionBlue.Visible = false;
            this.picInventoryPotionBlue.Click += new System.EventHandler(this.picInventoryPotionBlue_Click);
            // 
            // picInventorySword
            // 
            this.picInventorySword.BackColor = System.Drawing.Color.Transparent;
            this.picInventorySword.Image = global::TheQuest.Properties.Resources.sword;
            this.picInventorySword.Location = new System.Drawing.Point(78, 319);
            this.picInventorySword.Name = "picInventorySword";
            this.picInventorySword.Size = new System.Drawing.Size(50, 50);
            this.picInventorySword.TabIndex = 12;
            this.picInventorySword.TabStop = false;
            this.picInventorySword.Visible = false;
            this.picInventorySword.Click += new System.EventHandler(this.picInventorySword_Click);
            // 
            // picInventoryMace
            // 
            this.picInventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryMace.Image = global::TheQuest.Properties.Resources.mace;
            this.picInventoryMace.Location = new System.Drawing.Point(302, 319);
            this.picInventoryMace.Name = "picInventoryMace";
            this.picInventoryMace.Size = new System.Drawing.Size(50, 50);
            this.picInventoryMace.TabIndex = 13;
            this.picInventoryMace.TabStop = false;
            this.picInventoryMace.Visible = false;
            this.picInventoryMace.Click += new System.EventHandler(this.picInventoryMace_Click);
            // 
            // picInventoryPotionRed
            // 
            this.picInventoryPotionRed.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryPotionRed.Image = global::TheQuest.Properties.Resources.potion_red;
            this.picInventoryPotionRed.Location = new System.Drawing.Point(246, 319);
            this.picInventoryPotionRed.Name = "picInventoryPotionRed";
            this.picInventoryPotionRed.Size = new System.Drawing.Size(50, 50);
            this.picInventoryPotionRed.TabIndex = 14;
            this.picInventoryPotionRed.TabStop = false;
            this.picInventoryPotionRed.Visible = false;
            this.picInventoryPotionRed.Click += new System.EventHandler(this.picInventoryPotionRed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Move";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(650, 27);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 18;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(617, 56);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 19;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(698, 56);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 20;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(650, 85);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 21;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(650, 201);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(75, 23);
            this.btnAttackDown.TabIndex = 26;
            this.btnAttackDown.Text = "Down";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(698, 172);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(75, 23);
            this.btnAttackRight.TabIndex = 25;
            this.btnAttackRight.Text = "Right";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(617, 172);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAttackLeft.TabIndex = 24;
            this.btnAttackLeft.Text = "Left";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(650, 143);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(75, 23);
            this.btnAttackUp.TabIndex = 23;
            this.btnAttackUp.Text = "Up";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Attack";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.5F));
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerHP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBatHP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGhostHP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGhoulHP, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(617, 269);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(156, 100);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Location = new System.Drawing.Point(64, 6);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(89, 13);
            this.lblPlayerHP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bat";
            // 
            // lblBatHP
            // 
            this.lblBatHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBatHP.AutoSize = true;
            this.lblBatHP.Location = new System.Drawing.Point(64, 31);
            this.lblBatHP.Name = "lblBatHP";
            this.lblBatHP.Size = new System.Drawing.Size(89, 13);
            this.lblBatHP.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ghost";
            // 
            // lblGhostHP
            // 
            this.lblGhostHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGhostHP.AutoSize = true;
            this.lblGhostHP.Location = new System.Drawing.Point(64, 56);
            this.lblGhostHP.Name = "lblGhostHP";
            this.lblGhostHP.Size = new System.Drawing.Size(89, 13);
            this.lblGhostHP.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ghoul";
            // 
            // lblGhoulHP
            // 
            this.lblGhoulHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGhoulHP.AutoSize = true;
            this.lblGhoulHP.Location = new System.Drawing.Point(64, 81);
            this.lblGhoulHP.Name = "lblGhoulHP";
            this.lblGhoulHP.Size = new System.Drawing.Size(89, 13);
            this.lblGhoulHP.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(787, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picInventoryPotionRed);
            this.Controls.Add(this.picInventoryMace);
            this.Controls.Add(this.picInventorySword);
            this.Controls.Add(this.picInventoryPotionBlue);
            this.Controls.Add(this.picInventoryBow);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picBat);
            this.Controls.Add(this.picPotionBlue);
            this.Controls.Add(this.picPotionRed);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picGhoul);
            this.Controls.Add(this.picSword);
            this.Controls.Add(this.picBow);
            this.Controls.Add(this.picMace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPotionBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPotionBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPotionRed)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBow;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picGhoul;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.PictureBox picPotionRed;
        private System.Windows.Forms.PictureBox picPotionBlue;
        private System.Windows.Forms.PictureBox picBat;
        private System.Windows.Forms.PictureBox picSword;
        private System.Windows.Forms.PictureBox picMace;
        private System.Windows.Forms.PictureBox picInventoryBow;
        private System.Windows.Forms.PictureBox picInventoryPotionBlue;
        private System.Windows.Forms.PictureBox picInventorySword;
        private System.Windows.Forms.PictureBox picInventoryMace;
        private System.Windows.Forms.PictureBox picInventoryPotionRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBatHP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGhostHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGhoulHP;
    }
}

