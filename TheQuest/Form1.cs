using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            //Update the player's position and stats.
            picPlayer.Location = game.PlayerLocation;
            lblPlayerHP.Text = game.PlayerHP.ToString();

            //Update each enemy's location and HP.
            bool showBat = false, showGhost = false, showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    picBat.Location = enemy.Location;
                    lblBatHP.Text = enemy.HP.ToString();
                    if (enemy.HP > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    picGhost.Location = enemy.Location;
                    lblGhostHP.Text = enemy.HP.ToString();
                    if (enemy.HP > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else
                {
                    picGhoul.Location = enemy.Location;
                    lblGhoulHP.Text = enemy.HP.ToString();
                    if (enemy.HP > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            //Check which enemies should be displayed.
            if (showBat)
                picBat.Visible = true;
            else
                picBat.Visible = false;

            if (showGhost)
                picGhost.Visible = true;
            else
                picGhost.Visible = false;

            if (showGhoul)
                picGhoul.Visible = true;
            else
                picGhoul.Visible = false;

            //Check which weapon should be displayed.
            picSword.Visible = false;
            picBow.Visible = false;
            picPotionRed.Visible = false;
            picPotionBlue.Visible = false;
            picMace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = picSword;
                    break;

                case "Bow":
                    weaponControl = picBow;
                    break;

                case "Red Potion":
                    weaponControl = picPotionRed;
                    break;

                case "Blue Potion":
                    weaponControl = picPotionBlue;
                    break;

                case "Mace":
                    weaponControl = picMace;
                    break;

                default: break;
            }

            //See what inventory icons to display.
            if (game.CheckPlayerInventory("Sword"))
                picInventorySword.Visible = true;
            else
                picInventorySword.Visible = false;

            if (game.CheckPlayerInventory("Bow"))
                picInventoryBow.Visible = true;
            else
                picInventoryBow.Visible = false;

            if (game.CheckPlayerInventory("Red Potion"))
                picInventoryPotionRed.Visible = true;
            else
                picInventoryPotionRed.Visible = false;

            if (game.CheckPlayerInventory("Blue Potion"))
                picInventoryPotionBlue.Visible = true;
            else
                picInventoryPotionBlue.Visible = false;

            if (game.CheckPlayerInventory("Mace"))
                picInventoryMace.Visible = true;
            else
                picInventoryMace.Visible = false;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            if (game.PlayerHP <= 0)
            {
                MessageBox.Show("You died.");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level!");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void picInventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                removeOtherInventoryBorders();
                ChangeButtons(false);
                picInventorySword.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void picInventoryPotionBlue_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                removeOtherInventoryBorders();
                ChangeButtons(true);
                picInventoryPotionBlue.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void picInventoryBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                removeOtherInventoryBorders();
                ChangeButtons(false);
                picInventoryBow.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void picInventoryPotionRed_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                removeOtherInventoryBorders();
                ChangeButtons(true);
                picInventoryPotionRed.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void picInventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                removeOtherInventoryBorders();
                ChangeButtons(false);
                picInventoryMace.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void removeOtherInventoryBorders()
        {
            picInventorySword.BorderStyle = BorderStyle.None;
            picInventoryBow.BorderStyle = BorderStyle.None;
            picInventoryMace.BorderStyle = BorderStyle.None;
            picInventoryPotionRed.BorderStyle = BorderStyle.None;
            picInventoryPotionBlue.BorderStyle = BorderStyle.None;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void ChangeButtons(bool shutOff)
        {
            if (shutOff)
            {
                btnAttackDown.Visible = false;
                btnAttackLeft.Visible = false;
                btnAttackRight.Visible = false;
                btnAttackUp.Text = "Drink";
            }
            else
            {
                btnAttackDown.Visible = true;
                btnAttackLeft.Visible = true;
                btnAttackRight.Visible = true;
                btnAttackUp.Text = "Up";
            }
        }

        private void btnAttackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void btnAttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void btnAttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void btnAttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }
    }
}