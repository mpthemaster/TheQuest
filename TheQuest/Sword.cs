namespace TheQuest
{
    internal class Sword : Weapon
    {
        private Game game;
        private System.Drawing.Point point;

        public Sword(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }
    }
}