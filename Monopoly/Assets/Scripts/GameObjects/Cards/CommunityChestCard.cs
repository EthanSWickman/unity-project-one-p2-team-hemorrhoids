namespace GameObjects.Cards {
    public class CommunityChestCard{
        public class Advance : Card {
            private readonly int _placeToAdvance;
            public Advance(int placeToAdvance){
                _placeToAdvance = placeToAdvance;
                Type = 0;
            }

            public override int Activate(int[] values){
                throw new System.NotImplementedException();
            }

            public override int Activate(){
                return _placeToAdvance;
            }

            public override int Activate(int money){
                throw new System.NotImplementedException();
            }
        }
        public class GiveOrTakeMoney : Card {
            private readonly int _moneyToGiveOrTake;
            public GiveOrTakeMoney(int moneyToGiveOrTake){
                _moneyToGiveOrTake = moneyToGiveOrTake;
                Type = 1;
                
            }

            public override int Activate(int[] values){
                throw new System.NotImplementedException();
            }

            public override int Activate(){
                throw new System.NotImplementedException();
            }

            public override int Activate(int money){
                return money + _moneyToGiveOrTake;
            }
        }
        public class StreetRepairs : Card {
            private const int PricePerHouse = 40;
            private const int PricePerHotel = 115;
            public StreetRepairs(){
                Type = 2;
            }
            public override int Activate(int[] values){
                values[0] -= values[2] * PricePerHouse + values[3] * PricePerHotel;
                return values[0];
            }

            public override int Activate(){
                throw new System.NotImplementedException();
            }

            public override int Activate(int money){
                throw new System.NotImplementedException();
            }
        }

        public class GetOutOfJail : Card {
            public GetOutOfJail(){
                Type = 3;
            }
            public override int Activate(int[] values){
                throw new System.NotImplementedException();
            }

            public override int Activate(){
                throw new System.NotImplementedException();
            }

            public override int Activate(int placeToAdvance){
                throw new System.NotImplementedException();
            }
        }
        //Go To Jail 
    }
}