using System.Collections;
using System.Collections.Generic;
using GameObjects.BoardSpaces.ActionSpaces;
using GameObjects.BoardSpaces.BuyableSpaces;
using GameObjects.BoardSpaces.CardSpaces;
using GameObjects.Cards;
using RulesAndEnums;
using UnityEngine;
using Space = UnityEngine.Space;

namespace GameObjects{
    public class Board : MonoBehaviour{
        private const int BoardSize = 40;
        private BoardSpaces.Space[] _spaces = new BoardSpaces.Space[BoardSize];
        public List<Card> CommunityChest  { get; set;}
        public List<Card> Chance { get; set;}

        // Start is called before the first frame update
        void Start(){
            _spaces = RulesAndEnums.HARDCODED.SetBoardArray.SetUpBoardArray(_spaces);
        }

        private void WhenPlayerLandsOnSpace(Player player){
            if (_spaces[player.Position].GetType() == typeof(EstateSpace))
            {
                player.Money = _spaces[player.Position].WhenPlayerLandsOnSpace(player.Money);
            }
            else if (_spaces[player.Position].GetType() == typeof(GoSpace))
            {
                player.Money = _spaces[player.Position].WhenPlayerLandsOnSpace(player.Money);
            }
            else if (_spaces[player.Position].GetType() == typeof(DrawCardTile))
            {
                if (_spaces[player.Position].GetType() == typeof(ChanceSpace))
                {           
                    player.UseCard(Chance[0]);
                    Chance.RemoveAt(0);
                }
                else
                {
                    player.UseCard(CommunityChest[0]);
                    CommunityChest.RemoveAt(0);
                }
                
            }
        }


}
