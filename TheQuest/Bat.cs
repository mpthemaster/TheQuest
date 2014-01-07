using System;
using System.Drawing;

namespace TheQuest
{
    internal class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        { }

        /// <summary>
        /// Moves the Bat, and has it attack if nearby the player.
        /// </summary>
        /// <param name="random"></param>
        public override void Move(Random random)
        {
            //If the Bat is alive, move it. 50% chance it will move towards the player.
            if (base.HP > 0)
            {
                Direction directionTowardsPlayer = base.FindPlayerDirection(game.PlayerLocation);
                if (random.Next(2) == 0)
                {
                    base.location = base.Move(directionTowardsPlayer, game.Boundaries);

                    //If near the player, attack.
                    if (base.NearPlayer())
                        base.game.HitPlayer(2, random);
                }
                else
                {
                    Direction directionToMove = directionTowardsPlayer;
                    while (directionToMove == directionTowardsPlayer)
                    {
                        switch (random.Next(4))
                        {
                            case 0:
                                directionToMove = Direction.Up;
                                break;

                            case 1:
                                directionToMove = Direction.Right;
                                break;

                            case 2:
                                directionToMove = Direction.Down;
                                break;

                            case 3:
                                directionToMove = Direction.Left;
                                break;

                            default: break;
                        }
                    }
                    base.location = base.Move(directionToMove, game.Boundaries);
                }
            }
        }
    }
}