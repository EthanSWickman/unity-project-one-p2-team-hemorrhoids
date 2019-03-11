using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DiceFunctions : MonoBehaviour {
    public int diceOneValue;
    public int diceTwoValue;
    public int diceTotal;
    System.Random rnd = new System.Random();

    public void diceRoll(){
        Debug.Log("Rolling the dice...");
        diceOneValue = rnd.Next(0, 6);
        diceTwoValue = rnd.Next(0, 6);
    }

    public int getDiceTotalValue(){
        diceTotal = diceOneValue + diceTwoValue;
        return diceTotal;
    }
    
}
