using System.Collections.Generic;
using GameObjects.BoardSpaces;
using GameObjects.BoardSpaces.ActionSpaces;
using GameObjects.BoardSpaces.BuyableSpaces;
using GameObjects.BoardSpaces.CardSpaces;
using UnityEditor;
using UnityEngine;
using Space = GameObjects.BoardSpaces.Space;

namespace RulesAndEnums.HARDCODED {
    public class SetBoardArray : MonoBehaviour
    {
        public static Space[] SetUpBoardArray(){
            Space[] _spaces = new Space[40];
           
            _spaces[0] = new GoSpace();
            _spaces[1] = new EstateSpace(CreateEstatesValueArray(ColorValues.BrownLow));
            _spaces[2] = new CommunityChestSpace();
            _spaces[3] = new EstateSpace(CreateEstatesValueArray(ColorValues.BrownHigh));
            _spaces[4] = new TaxSpace();
            _spaces[5] = new RailRoad();
            _spaces[6] = new EstateSpace(CreateEstatesValueArray(ColorValues.LightBlueLow));
            _spaces[7] = new ChanceSpace();
            _spaces[8] = new EstateSpace(CreateEstatesValueArray(ColorValues.LightBlueLow));
            _spaces[9] = new EstateSpace(CreateEstatesValueArray(ColorValues.LightBlueHigh));
            _spaces[10] = new JailSpace();
            _spaces[11] = new EstateSpace(CreateEstatesValueArray(ColorValues.PinkLow));
            _spaces[12] = new UtilitySpace();
            _spaces[13] = new EstateSpace(CreateEstatesValueArray(ColorValues.PinkLow));
            _spaces[14] = new EstateSpace(CreateEstatesValueArray(ColorValues.PinkHigh));
            _spaces[15] = new RailRoad();
            _spaces[16] = new EstateSpace(CreateEstatesValueArray(ColorValues.OrangeLow));
            _spaces[17] = new CommunityChestSpace();
            _spaces[18] = new EstateSpace(CreateEstatesValueArray(ColorValues.OrangeLow));
            _spaces[19] = new EstateSpace(CreateEstatesValueArray(ColorValues.OrangeHigh));
            _spaces[20] = new FreeParling();
            _spaces[21] = new EstateSpace(CreateEstatesValueArray(ColorValues.RedLow));
            _spaces[22] = new ChanceSpace();
            _spaces[23] = new EstateSpace(CreateEstatesValueArray(ColorValues.RedLow));
            _spaces[24] = new EstateSpace(CreateEstatesValueArray(ColorValues.RedHigh));
            _spaces[25] = new RailRoad();
            _spaces[26] = new EstateSpace(CreateEstatesValueArray(ColorValues.YellowLow));
            _spaces[27] = new EstateSpace(CreateEstatesValueArray(ColorValues.YellowLow));
            _spaces[28] = new UtilitySpace();
            _spaces[29] = new EstateSpace(CreateEstatesValueArray(ColorValues.YellowHigh));
            _spaces[30] = new GoToJailSpace();
            _spaces[31] = new EstateSpace(CreateEstatesValueArray(ColorValues.GreenLow));
            _spaces[32] = new EstateSpace(CreateEstatesValueArray(ColorValues.GreenLow));
            _spaces[33] = new CommunityChestSpace();
            _spaces[34] = new EstateSpace(CreateEstatesValueArray(ColorValues.GreenHigh));
            _spaces[35] = new RailRoad();
            _spaces[36] = new ChanceSpace();
            _spaces[37] = new EstateSpace(CreateEstatesValueArray(ColorValues.DarkBlueLow));
            _spaces[38] = new TaxSpace();
            _spaces[39] = new EstateSpace(CreateEstatesValueArray(ColorValues.DarkBlueHigh));

            return _spaces;
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
