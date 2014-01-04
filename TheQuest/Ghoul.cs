namespace TheQuest
{
    internal class Ghoul : Enemy
    {
        private Game game;
        private System.Drawing.Point point;

        public Ghoul(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }
    }
}