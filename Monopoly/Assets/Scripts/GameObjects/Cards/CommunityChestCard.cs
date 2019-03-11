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
            private const int PricePerHouse = 40;
            private const int PricePerHotel = 115;
            public override int[] Activate(int[] values){
                values[0] -= values[2] * PricePerHouse + values[3] * PricePerHotel;
                return values;
            }
        }

        public class GoToJail : Card {
            public GoToJail(){
                IsGetOutOfJail = true;
            }
            public override int[] Activate(int[] values){
                values = new int[1];
                return values;
            }
        }
    }
}