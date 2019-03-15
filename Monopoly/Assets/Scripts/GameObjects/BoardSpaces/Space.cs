using GameObjects.Cards;
using UnityEngine.EventSystems;

namespace GameObjects.BoardSpaces{
    public abstract class Space{
        private string _spaceName;
        private int _typeOfSpace;

        public string SpaceName
        {
            get => _spaceName;
            set => _spaceName = value;
        }

        public int TypeOfSpace
        {
            get => _typeOfSpace;
            set => _typeOfSpace = value;
        }

        public abstract int WhenPlayerLandsOnSpace(int money);

        public abstract Card WhenPlayerLandsOnSpace();
        
    }
}
