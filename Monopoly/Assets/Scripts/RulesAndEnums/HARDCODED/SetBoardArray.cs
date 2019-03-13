using System.Collections.Generic;
using GameObjects.Cards;
using GameObjects.Spaces;
using RulesAndEnums;
using UnityEngine;


public class SetBoardArray : MonoBehaviour
{
    public static GameObjects.Spaces.Space[] SetUpBoardArray(GameObjects.Spaces.Space[] _spaces){
        if (_spaces != null) {
            
            _spaces[39] = new EstateSpace(CreateEstatesValueArray(ColorValues.DarkBlueHigh));
        }
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
