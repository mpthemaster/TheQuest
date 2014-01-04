namespace TheQuest
{
    internal class Bat : Enemy
    {
        private Game game;
        private System.Drawing.Point point;

        public Bat(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }
    }
}