using System.Drawing;

namespace TheQuest
{
    internal class PotionRed : Weapon, IPotion
    {
        public PotionRed(Game game, Point location)
            : base(game, location)
        { }

        public override string Name { get { return "Red Potion"; } }

        public override void Attack(Direction direction, System.Random random)
        {
            game.IncreasePlayerHealth(10, random);
            used = true;
        }

        private bool used = false;

        public bool Used
        {
            get { return used; }
        }
    }
}