using System.Collections;
using System.Collections.Generic;
using GameObjects.BoardSpaces;
using GameObjects.Cards;
using RulesAndEnums;
using UnityEngine;
using Space = UnityEngine.Space;

namespace GameObjects{
    public class Board : MonoBehaviour{
        private const int BoardSize = 40;
        public BoardSpaces.Space[] _spaces = new BoardSpaces.Space[BoardSize];
        private List<CommunityChestCard> _communityChest;
        private List<ChanceCards> _chance;

        // Start is called before the first frame update
        void Start(){
            _spaces[39] = new EstateSpace(CreateEstatesValueArray(ColorValues.DarkBlueHigh));
        }

        public BoardSpaces.Space[] Spaces {
            get => _spaces;
            set => _spaces = value;
        }


}
