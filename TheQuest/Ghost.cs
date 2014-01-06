using System;
using System.Drawing;

namespace TheQuest
{
    internal class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        { }

        /// <summary>
        /// Moves the Ghost, and has it attack if nearby the player.
        /// </summary>
        /// <param name="random"></param>
        public override void Move(Random random)
        {
            //If the Ghost is alive, move it. 33% chance it will move towards the player.
            if (base.HP > 0)
            {
                Direction directionTowardsPlayer = base.FindPlayerDirection(game.PlayerLocation);
                if (random.Next(3) == 0)
                {
                    base.location = base.Move(directionTowardsPlayer, game.Boundaries);

                    //If near the player, attack.
                    if (base.NearPlayer())
                        base.game.HitPlayer(3, random);
                }
            }
        }
    }
}