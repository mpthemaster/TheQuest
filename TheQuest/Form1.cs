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