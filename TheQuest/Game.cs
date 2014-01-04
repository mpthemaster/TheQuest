using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    internal class Game
    {
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;

        private Player player;

        public Point PlayerLocation { get { return player.Location; } }

        public int PlayerHP { get { return player.HP; } }

        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;

        public int Level { get { return level; } }

        private Rectangle boundaries;

        public Rectangle Boundaries { get { return boundaries; } }

        /// <summary>
        /// Game starts out with a bounding box for the dungeon and creates a new Player object inside the dungeon.
        /// </summary>
        /// <param name="boundaries"></param>
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        /// <summary>
        /// Moves the player based on the user's input and moves each enemy randomly.
        /// </summary>
        /// <param name="direction">The direction the player is moving in.</param>
        /// <param name="random">The Random object to determine each enemy's random movement.</param>
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        /// <summary>
        /// Equips the player with a user-selected weapon.
        /// </summary>
        /// <param name="weaponName">The weapon the player should now use.</param>
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        /// <summary>
        /// Check if the player's inventory contains the specified weapon.
        /// </summary>
        /// <param name="weaponName">The name of the weapon to check for.</param>
        /// <returns>Returns true if the player has the specified weapon.</returns>
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        /// <summary>
        /// Hits the player with damage.
        /// </summary>
        /// <param name="maxDamage">The maximum amount of damage.</param>
        /// <param name="random">The random object to determine how much damage occurred.</param>
        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        /// <summary>
        /// Increase the player's health.
        /// </summary>
        /// <param name="health"></param>
        /// <param name="random"></param>
        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        /// <summary>
        /// The player attacks and then each enemy gets a turn to move.
        /// </summary>
        /// <param name="direction">The direction the player is attacking.</param>
        /// <param name="random"></param>
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        /// <summary>
        /// Used to determine where to place enemies and weapons.
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        public Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        /// <summary>
        /// Creates each level with an increased difficulty.
        /// </summary>
        /// <param name="random"></param>
        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;

                case 2:
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new PotionBlue(this, GetRandomLocation(random));
                    break;

                case 3:
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;

                case 4:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    if (player.Weapons.Contains("Bow"))
                        if (player.Weapons.Contains("Blue Potion"))
                            ;
                        else
                            WeaponInRoom = new PotionBlue(this, GetRandomLocation(random));
                    else
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;

                case 5:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new PotionRed(this, GetRandomLocation(random));
                    break;

                case 6:
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;

                case 7:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    if (player.Weapons.Contains("Mace"))
                        if (player.Weapons.Contains("Red Potion"))
                            ;
                        else
                            WeaponInRoom = new PotionRed(this, GetRandomLocation(random));
                    else
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;

                case 8:
                    Application.Exit();
                    break;

                default:
                    break;
            }
        }
    }
}