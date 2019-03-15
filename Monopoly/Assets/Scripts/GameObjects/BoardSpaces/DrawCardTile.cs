namespace GameObjects.BoardSpaces {
    public class DrawCardTile : Space {
        private bool _chanceOrCommunityChest;

        public DrawCardTile(bool chanceOrCommunityChest){
            _chanceOrCommunityChest = chanceOrCommunityChest;
        }

        public override void WhenPlayerLandsOnSpace(){
            
        }
    }
}