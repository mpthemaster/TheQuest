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
                    if (base.Nearby(enemy.Location, target, radius) && !enemy.Dead)
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                target = base.Move(direction, target, game.Boundaries);
            }
            return false;
        }

        /// <summary>
        /// Calculates the direction clockwise or counter-clockwise of the current direction.
        /// </summary>
        /// <param name="startingDirection">The current direction.</param>
        /// <param name="clockwise">If true, calculates the direction clockwise of the current position.</param>
        /// <returns>Returns the calculated direction.</returns>
        protected Direction newDirection(Direction startingDirection, bool clockwise)
        {
            if (clockwise)
            {
                startingDirection++;
                if ((int)startingDirection > 3)
                    startingDirection = (Direction)0;
            }
            else
            {
                startingDirection--;
                if ((int)startingDirection < 0)
                    startingDirection = (Direction)3;
            }
            return startingDirection;
        }
    }
}