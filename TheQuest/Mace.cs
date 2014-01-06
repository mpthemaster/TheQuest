using System;
using System.Drawing;

namespace TheQuest
{
    internal class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location)
        { }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            int radius = 20, damage = 6;

            if (!DamageEnemy(direction, radius, damage, random))
            {
                direction = newDirection(direction, false);
                if (!DamageEnemy(direction, radius, damage, random))
                {
                    direction = newDirection(direction, false);
                    if (!DamageEnemy(direction, radius, damage, random))
                    {
                        DamageEnemy(newDirection(direction, false), radius, damage, random);
                    }
                }
            }
        }
    }
}