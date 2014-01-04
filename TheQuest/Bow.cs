namespace TheQuest
{
    internal class Bow : Weapon
    {
        private Game game;
        private System.Drawing.Point point;

        public Bow(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }
    }
}