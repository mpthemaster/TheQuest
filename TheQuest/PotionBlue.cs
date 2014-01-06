using System;
using System.Drawing;

namespace TheQuest
{
    internal class PotionBlue : Weapon
    {
        public PotionBlue(Game game, Point location)
            : base(game, location)
        { }

        public override string Name { get { return "Blue Potion"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
        }
    }
}