using System;
using System.Drawing;

namespace TheQuest
{
    internal class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        { }

        /// <summary>
        /// Moves the Ghoul, and has it attack if nearby the player.
        /// </summary>
        /// <param name="random"></param>
        public override void Move(Random random)
        {
            //If the Ghoul is alive, move it. 50% chance it will move towards the player.
            if (base.HP > 0)
            {
                Direction directionTowardsPlayer = base.FindPlayerDirection(game.PlayerLocation);
                int moveChance = random.Next(3);
                if (moveChance == 0 || moveChance == 1)
                {
                    base.location = base.Move(directionTowardsPlayer, game.Boundaries);

                    //If near the player, attack.
                    if (base.NearPlayer())
                        base.game.HitPlayer(4, random);
                }
            }
        }
    }
}