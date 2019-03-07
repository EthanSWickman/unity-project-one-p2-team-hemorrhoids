using RulesAndEnums;

namespace GameObjects{
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
    }
}