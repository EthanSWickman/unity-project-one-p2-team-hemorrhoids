
using GameObjects.Cards;

namespace GameObjects.BoardSpaces.ActionSpaces {
    public class GoSpace : Space {

        private const int CollectMoneyOnGo = 200;

        public override int WhenPlayerLandsOnSpace(int money){
            return money += CollectMoneyOnGo;
        }

        public override Card WhenPlayerLandsOnSpace(){
            throw new System.NotImplementedException();
        }
    }
}
