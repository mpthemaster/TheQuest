using System;
using System.Drawing;

namespace TheQuest
{
    internal abstract class Mover
    {
        //One step in any direction.
        private const int MoveInterval = 10;

        protected Point location;

        public Point Location { get { return location; } }

        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        /// <summary>
        /// Check if two objects are near each other.
        /// </summary>
        /// <param name="locationToCheck">An object's location to check against.</param>
        /// <param name="distance">The distance for the object to be considered close by.</param>
        /// <returns></returns>
        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Move one step in any direction.
        /// </summary>
        /// <param name="direction">The direction to move in.</param>
        /// <param name="boundaries">The boundaries of the map.</param>
        /// <returns></returns>
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;

                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;

                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;

                case Direction.Right:
                    if (newLocation.X + MoveInterval >= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;

                default: break;
            }
            return newLocation;
        }

        public bool Nearby(Point location, Point target, int radius)
        {
            if (Math.Abs(location.X - target.X) < radius && Math.Abs(location.Y - target.Y) < radius)
                return true;
            else
                return false;
        }

        public Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            Point newLocation = target;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;

                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;

                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;

                case Direction.Right:
                    if (newLocation.X + MoveInterval >= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;

                default: break;
            }
            return newLocation;
        }
    }
}