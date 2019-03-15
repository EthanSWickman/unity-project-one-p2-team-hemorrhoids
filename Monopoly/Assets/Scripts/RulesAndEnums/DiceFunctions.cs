using UnityEngine;

namespace RulesAndEnums {
    public class DiceFunctions : MonoBehaviour {
        public int diceOneValue;
        public int diceTwoValue;
        public int diceTotal;
        System.Random _rnd = new System.Random();

        public void DiceRoll(){
            Debug.Log("Rolling the dice...");
            diceOneValue = _rnd.Next(0, 6);
            diceTwoValue = _rnd.Next(0, 6);
        }

        public int GetDiceTotalValue(){
            diceTotal = diceOneValue + diceTwoValue;
            return diceTotal;
        }
    
    }
}
