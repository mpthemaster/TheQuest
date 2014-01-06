namespace TheQuest
{
    internal class Weapon : Mover
    {
        public string Name { get; set; }

        public bool PickedUp { get; set; }

        internal void Attack(Direction direction, System.Random random)
        {
            throw new System.NotImplementedException();
        }
    }
}