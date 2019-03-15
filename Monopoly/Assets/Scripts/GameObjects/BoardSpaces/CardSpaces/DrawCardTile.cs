using GameObjects.Cards;

namespace GameObjects.BoardSpaces.CardSpaces {
    public class DrawCardTile : Space {
        public bool ChanceOrCommunityChest  { get; set;}

        public DrawCardTile(bool chanceOrCommunityChest){
        }

        public override int WhenPlayerLandsOnSpace(int money){
            throw new System.NotImplementedException();
        }

        public override Card WhenPlayerLandsOnSpace(){
            
            throw new System.NotImplementedException();
        }
    }
}