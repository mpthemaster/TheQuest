namespace TheQuest
{
    internal class Player
    {
        private Game game;
        private System.Drawing.Point point;

        public Player(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }

        public System.Drawing.Point Location { get; set; }

        public int HP { get; set; }

        public System.Collections.Generic.List<string> Weapons { get; set; }

        internal void Move(Direction direction)
        {
            throw new System.NotImplementedException();
        }

        internal void Equip(string weaponName)
        {
            throw new System.NotImplementedException();
        }

        internal void Hit(int maxDamage, System.Random random)
        {
            throw new System.NotImplementedException();
        }

        internal void IncreaseHealth(int health, System.Random random)
        {
            throw new System.NotImplementedException();
        }

        internal void Attack(Direction direction, System.Random random)
        {
            throw new System.NotImplementedException();
        }
    }
}