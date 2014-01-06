using System;
using System.Drawing;

namespace TheQuest
{
    internal class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location)
        { }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            int radius = 10, damage = 3;

            if (!DamageEnemy(direction, radius, damage, random))
                if (!DamageEnemy(newDirection(direction, true), radius, damage, random))
                    DamageEnemy(newDirection(direction, false), radius, damage, random);
        }
    }
}