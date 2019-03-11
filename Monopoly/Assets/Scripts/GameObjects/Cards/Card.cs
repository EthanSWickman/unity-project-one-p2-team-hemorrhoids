namespace GameObjects.Cards{
    public abstract class Card {
        private bool _isGetOutOfJail;

        public bool IsGetOutOfJail
        {
            get => _isGetOutOfJail;
            set => _isGetOutOfJail = value;
        }

        public abstract int[] Activate(int[] values);
    }
}