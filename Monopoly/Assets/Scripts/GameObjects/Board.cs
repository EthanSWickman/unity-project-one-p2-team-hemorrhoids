using System.Collections.Generic;
using UnityEngine;

namespace GameObjects{
    public class Board : MonoBehaviour{
        private const int BoardSize = 40;
        private UnityEngine.Space[] _spaces = new UnityEngine.Space[BoardSize];

    
        // Start is called before the first frame update
        void Start()
        {
            //create the tiles
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
