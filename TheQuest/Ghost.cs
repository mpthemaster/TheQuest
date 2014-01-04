namespace TheQuest
{
    internal class Ghost : Enemy
    {
        private Game game;
        private System.Drawing.Point point;

        public Ghost(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }
    }
}