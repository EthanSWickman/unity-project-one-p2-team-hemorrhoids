using System.Collections.Generic;
using GameObjects.Cards;

namespace GameObjects{
    public class Player{
        private int _money;
        private int _estatesOwned;
        private int _housesOwned;
        private int _hotelsOwned;
        private int _position;
        private List<Card> _cards;
        private bool _isInJail;

        public Player(int money, int position){
            _money = money;
            _position = position;
        }

        public void MovePlayer(){
            
            
        }

        public void UseCard(Card card){
            int[] values = card.Activate(new[]{_money, _position, _housesOwned, _hotelsOwned});
            if (values.Length == 1)
            {
                _isInJail = false;
            }
            else
            {
                _money = values[0];
                _position = values[1];
            }
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
        public int HousesOwned
        {
            get => _housesOwned;
            set => _housesOwned = value;
        }

        public int HotelsOwned
        {
            get => _hotelsOwned;
            set => _hotelsOwned = value;
        }

        public bool IsInJail
        {
            get => _isInJail;
            set => _isInJail = value;
        }
    }
}