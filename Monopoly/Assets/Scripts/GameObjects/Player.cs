using System.Collections.Generic;

namespace GameObjects{
    public class Player{
        private int _money;
        private int _estatesOwned;
        private int _position;
        private List<Card> _cards;
        
        public Player(int money, int position){
            _money = money;
            _position = position;
        }

        public int Money
        {
            get => _money;
            set => _money = value;
        }

        public int EstatesOwned
        {
            get => _estatesOwned;
            set => _estatesOwned = value;
        }

        public int Position
        {
            get => _position;
            set => _position = value;
        }

        public List<Card> Cards
        {
            get => _cards;
            set => _cards = value;
        }
    }
}