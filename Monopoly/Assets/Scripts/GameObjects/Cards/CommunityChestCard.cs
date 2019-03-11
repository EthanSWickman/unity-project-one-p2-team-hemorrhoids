namespace GameObjects.Cards {
    public class CommunityChestCard{
        public class Advance : Card {

            private readonly int _placeToAdvance;
            public Advance(int placeToAdvance){
                _placeToAdvance = placeToAdvance;
            }

            public override int[] Activate(int[] values){
                values[1] = _placeToAdvance;
                return values;
            }
        }

        public class GiveOrTakeMoney : Card {
            private readonly int _moneyToGiveOrTake;

            public GiveOrTakeMoney(int moneyToGiveOrTake){
                _moneyToGiveOrTake = moneyToGiveOrTake;
            }

            public override int[] Activate(int[] values){
                values[0] = _moneyToGiveOrTake;
                return values;
            }
        }

        public class StreetRepairs : Card {
            public override int[] Activate(int[] values){
                
            }
        }
    }
}