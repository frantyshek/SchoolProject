using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dnaBody : MonoBehaviour
{
    int coins;
    int thisGameCoins;
    public Text dna;

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", coins);
        IncreaseCoin();
        GameOver();
    }

        public void IncreaseCoin()
    {
        thisGameCoins += Score.scoreValue/2;
        coins += thisGameCoins;
    }
        public void GameOver()
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.Save();
        Debug.Log(coins);
        dna.text = "DNA: " + coins;
}
}
