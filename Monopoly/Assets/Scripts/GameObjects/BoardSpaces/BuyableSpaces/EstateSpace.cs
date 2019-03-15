using GameObjects.Cards;
using RulesAndEnums;

namespace GameObjects.BoardSpaces.BuyableSpaces{
    public class EstateSpace : Space{

        private int[] _values;
        //these are what the indexes are

        public EstateSpace(int[] values){
            this._values = values;
        }

        public int GetValue(TypesOfValues typesOfValue){
            var index = (int) typesOfValue;
            return index;
        }

        public override int WhenPlayerLandsOnSpace(int money){
            throw new System.NotImplementedException();
        }

        public override Card WhenPlayerLandsOnSpace(){
            throw new System.NotImplementedException();
        }
    }
}