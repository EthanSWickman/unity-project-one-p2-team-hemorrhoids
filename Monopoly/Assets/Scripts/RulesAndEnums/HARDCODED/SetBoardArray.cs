using System.Collections.Generic;
using GameObjects.BoardSpaces;
using GameObjects.BoardSpaces.ActionSpaces;
using GameObjects.BoardSpaces.BuyableSpaces;
using UnityEngine;
using Space = GameObjects.BoardSpaces.Space;

namespace RulesAndEnums.HARDCODED {
    public class SetBoardArray : MonoBehaviour
    {
        public static Space[] SetUpBoardArray(){
            Space[] _spaces = new Space[40];
           
            _spaces[0] = new GoSpace();
            _spaces[1] = new EstateSpace(CreateEstatesValueArray(ColorValues.BrownHigh));
            _spaces[2] = new EstateSpace(CreateEstatesValueArray(ColorValues.BrownLow));
            _spaces[3]
            _spaces[4]
            _spaces[5]
            _spaces[6]
            _spaces[7]
            _spaces[8]
            _spaces[9]
            _spaces[10]
            _spaces[11]
            _spaces[12]
            _spaces[39] = new EstateSpace(CreateEstatesValueArray(ColorValues.DarkBlueHigh));
                
        }
        private static int[] CreateEstatesValueArray(IReadOnlyList<int> baseValues){ //creates the values array for when we create the EstateSpaces
            var finalValues = new int[baseValues.Count + 3];

            int i;
            for (i = 0; i < baseValues.Count; i++)
            {
                finalValues[i] = baseValues[i];
            }

            for (; i < baseValues.Count + 3; i++)
            {
                finalValues[i] = 0;
            }

            return finalValues;
        }
    }
}
}
}
