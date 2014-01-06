using System;
using System.Drawing;

namespace TheQuest
{
    internal abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        private int hp;

        public int HP { get { return hp; } }

        public bool Dead
        {
            get
            {
                if (hp <= 0)
                    return true;
                else
                    return false;
            }
        }

        public Enemy(Game game, Point location, int hp)
            : base(game, location)
        {
            this.hp = hp;
        }

        /// <summary>
        /// Moves the enemy as its behavior is declared.
        /// </summary>
        /// <param name="random"></param>
        public abstract void Move(Random random);

        /// <summary>
        /// Deducts hp from an enemy when an enemy is hit by the player.
        /// </summary>
        /// <param name="maxDamage">The maximum damage that the player's weapon can do.</param>
        /// <param name="random"></param>
        public void Hit(int maxDamage, Random random)
        {
            hp -= random.Next(1, maxDamage);
        }

        /// <summary>
        /// Checks if the enemy is near the player.
        /// </summary>
        /// <returns>Returns true if the enemy is near the player.</returns>
        protected bool NearPlayer()
        {
            return base.Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        /// <summary>
        /// Figures out what direction from the enemy's position that the player is.
        /// </summary>
        /// <param name="playerLocation">The location of the player.</param>
        /// <returns>Returns the direction the player is relative to the enemy.</returns>
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }
}