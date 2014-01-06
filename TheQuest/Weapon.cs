using System;
using System.Drawing;

namespace TheQuest
{
    internal abstract class Weapon : Mover
    {
        private bool pickedUp;

        public bool PickedUp { get { return pickedUp; } }

        public abstract string Name { get; }

        public Weapon(Game game, Point location)
            : base(game, location)
        {
            pickedUp = false;
        }

        public void PickUpWeapon()
        {
            pickedUp = true;
        }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                    if (base.Nearby(enemy.Location, target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                target = base.Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}