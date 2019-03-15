using GameObjects.Cards;

namespace GameObjects.BoardSpaces.CardSpaces {
    public class DrawCardTile : Space {
        private bool _chanceOrCommunityChest;

        public DrawCardTile(bool chanceOrCommunityChest){
            _chanceOrCommunityChest = chanceOrCommunityChest;
        }

        public override int WhenPlayerLandsOnSpace(int money){
            throw new System.NotImplementedException();
        }

        public override Card WhenPlayerLandsOnSpace(){
            
        }
    }
}