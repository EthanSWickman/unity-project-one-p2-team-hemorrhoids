using System;
using System.Collections.Generic;
using GameObjects.Cards;

namespace RulesAndEnums.HARDCODED {
    public class CreateDecks {
        private static readonly Random Random = new Random();
        public static List<Card> CreateCommunityChestDeck(){
            
        }

        public static List<Card> CreateChanceDeck(){
            
        }

        private static List<Card> ShuffleDeck(List<Card> cards){
            //Stolen off of Stack Overflow
            var n = cards.Count;  
            while (n > 1) {  
                n--;  
                var k = Random.Next(n + 1);  
                var value = cards[k];  
                cards[k] = cards[n];  
                cards[n] = value;  
            }  
        }
    }
}