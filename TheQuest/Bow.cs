using System;
using System.Drawing;

namespace TheQuest
{
    internal class Bow : Weapon
    {
        public Bow(Game game, Point location)
            : base(game, location)
        { }

        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {
            int radius = 30, damage = 1;
            DamageEnemy(direction, radius, damage, random);
        }
    }
}