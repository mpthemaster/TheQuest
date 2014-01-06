using System;
using System.Collections.Generic;
using System.Drawing;

namespace TheQuest
{
    internal class Player : Mover
    {
        private Weapon equippedWeapon;
        private int hp;

        public int HP { get; set; }

        private List<Weapon> inventory = new List<Weapon>();

        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location)
            : base(game, location)
        {
            hp = 10;
        }

        /// <summary>
        /// Moves the player one unit.
        /// </summary>
        /// <param name="direction">The direction to move the player one unit in.</param>
        public void Move(Direction direction)
        {
            base.location = base.Move(direction, game.Boundaries);

            //If the player is nearby a weapon on the floor in the room, have the player pick it up.
            //  If this is the player's first weapon, equip it.
            if (!game.WeaponInRoom.PickedUp && base.Nearby(game.WeaponInRoom.Location, 1))
            {
                inventory.Add(game.WeaponInRoom);
                game.WeaponInRoom.PickUpWeapon();
                if (equippedWeapon == null)
                    Equip(game.WeaponInRoom.Name);
            }
        }

        /// <summary>
        /// Equip a weapon for the player.
        /// </summary>
        /// <param name="weaponName">The name of the weapon to equip.</param>
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
        }

        /// <summary>
        /// Decreases the player's hp after the player has been hit.
        /// </summary>
        /// <param name="maxDamage">The upper limit of damage based on the enemy type.</param>
        /// <param name="random"></param>
        public void Hit(int maxDamage, Random random)
        {
            hp -= random.Next(1, ++maxDamage);
        }

        /// <summary>
        /// Increases the player's hp.
        /// </summary>
        /// <param name="health">The maximum amount that a potion increases health by.</param>
        /// <param name="random"></param>
        public void IncreaseHealth(int health, Random random)
        {
            hp += random.Next(1, health);
        }

        /// <summary>
        /// The player is attacking or using a potion.
        /// </summary>
        /// <param name="direction">The direction the player is attacking.</param>
        /// <param name="random"></param>
        public void Attack(Direction direction, Random random)
        {
            //If the player has a weapon equipped, attack with it.
            //  If the weapon equipped is a potion, remove it from the player's inventory now that it has been used.
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                    inventory.Remove(equippedWeapon);
            }
        }
    }
}