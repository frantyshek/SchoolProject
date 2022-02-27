using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButtons : MonoBehaviour
{

    public Text levelDamage;
    public Text levelSpeed;

    public Text dna;

    public Text upgradeButtonCostDamage;
    public Text upgradeButtonCostSpeed;

    public Slider damageSlider;
    public Slider speedSlider;

    void Start()
    {
        dna.text = PlayerPrefs.GetInt("Coins").ToString();

        if(PlayerPrefs.GetInt("Damage") == 0)
        {
            levelDamage.text = "Poškodenie: 1";
        }
        else
        {
        levelDamage.text = "Poškodenie: " + PlayerPrefs.GetInt("Damage").ToString();
        }

        if(PlayerPrefs.GetInt("Speed") == 0)
        {
        levelSpeed.text = "Úroveň rýchlosti útoku: 1";
        }
        else
        {
        levelSpeed.text = "Úroveň rýchlosti útoku: " + PlayerPrefs.GetInt("Speed").ToString();
        }

        if(PlayerPrefs.GetInt("dNeed") == 0)
        {
            PlayerPrefs.SetInt("dNeed", 10);
        }

        if(PlayerPrefs.GetInt("sNeed") == 0)
        {
            PlayerPrefs.SetInt("sNeed", 20);
        }

        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("dNeed").ToString() + " DNA bodov"; 
        upgradeButtonCostSpeed.text = "Potrebujete: " + PlayerPrefs.GetInt("sNeed").ToString() + " DNA bodov";

        damageSlider.value = PlayerPrefs.GetInt("dLevel");
        speedSlider.value = PlayerPrefs.GetInt("sLevel");
        
        
    }

    public void UpgradeDamage()
    {
        if(PlayerPrefs.GetInt("dLevel") < 6)
        {
            switch(PlayerPrefs.GetInt("dLevel"))
            {
                case 0:
                    if(PlayerPrefs.GetInt("Coins") >= 10)
                    {
                        PlayerPrefs.SetInt("dLevel", 1);
                        damageSlider.value = PlayerPrefs.GetInt("dLevel");
                        PlayerPrefs.SetInt("Damage", 2);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 10);
                        levelDamage.text = "Poškodenie: " + PlayerPrefs.GetInt("Damage").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("dNeed", 30);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("dNeed").ToString() + " DNA bodov";
                    }
                    break;
                
                case 1:
                    if(PlayerPrefs.GetInt("Coins") >= 30)
                    {
                        PlayerPrefs.SetInt("dLevel", 2);
                        damageSlider.value = PlayerPrefs.GetInt("dLevel");
                        PlayerPrefs.SetInt("Damage", 4);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 30);
                        levelDamage.text = "Poškodenie: " + PlayerPrefs.GetInt("Damage").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("dNeed", 75);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("dNeed").ToString() + " DNA bodov";
                    }
                    break;

                case 2:
                    if(PlayerPrefs.GetInt("Coins") >= 75)
                    {
                        PlayerPrefs.SetInt("dLevel", 3);
                        damageSlider.value = PlayerPrefs.GetInt("dLevel");
                        PlayerPrefs.SetInt("Damage", 7);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 75);
                        levelDamage.text = "Poškodenie: " + PlayerPrefs.GetInt("Damage").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("dNeed", 200);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("dNeed").ToString() + " DNA bodov";
                    }
                    break;

                case 3:
                    if(PlayerPrefs.GetInt("Coins") >= 200)
                    {
                        PlayerPrefs.SetInt("dLevel", 4);
                        damageSlider.value = PlayerPrefs.GetInt("dLevel");
                        PlayerPrefs.SetInt("Damage", 10);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 200);
                        levelDamage.text = "Poškodenie: " + PlayerPrefs.GetInt("Damage").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("dNeed", 500);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("dNeed").ToString() + " DNA bodov";
                    }
                    break;        

                case 4:
                    if(PlayerPrefs.GetInt("Coins") >= 500)
                    {
                        PlayerPrefs.SetInt("dLevel", 5);
                        damageSlider.value = PlayerPrefs.GetInt("dLevel");
                        PlayerPrefs.SetInt("Damage", 15);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 500);
                        levelDamage.text = "Poškodenie: " + PlayerPrefs.GetInt("Damage").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("dNeed", 1500);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("dNeed").ToString() + " DNA bodov";
                    }
                    break;     

                case 5:
                    if(PlayerPrefs.GetInt("Coins") >= 1500)
                    {
                        PlayerPrefs.SetInt("dLevel", 6);
                        damageSlider.value = PlayerPrefs.GetInt("dLevel");
                        PlayerPrefs.SetInt("Damage", 20);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 1500);
                        levelDamage.text = "Poškodenie: " + PlayerPrefs.GetInt("Damage").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        upgradeButtonCostDamage.text = "Maximálne poškodenie";
                    }
                    break;                     
            }
        }
    }

    public void UpgradeSpeed()
    {
        if(PlayerPrefs.GetInt("sLevel") < 10)
        {
            switch(PlayerPrefs.GetInt("sLevel"))
            {
                case 0:
                    if(PlayerPrefs.GetInt("Coins") >= 20)
                    {
                        PlayerPrefs.SetInt("sLevel", 1);
                        speedSlider.value = PlayerPrefs.GetInt("sLevel");
                        PlayerPrefs.SetInt("Speed", 2);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 20);
                        levelSpeed.text = "Úroveň rýchlosti útoku: " + PlayerPrefs.GetInt("Speed").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("sNeed", 50);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("sNeed").ToString() + " DNA bodov";
                    }
                    break;
                
                case 1:
                    if(PlayerPrefs.GetInt("Coins") >= 50)
                    {
                        PlayerPrefs.SetInt("sLevel", 2);
                        speedSlider.value = PlayerPrefs.GetInt("sLevel");
                        PlayerPrefs.SetInt("Speed", 3);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 50);
                        levelSpeed.text = "Úroveň rýchlosti útoku: " + PlayerPrefs.GetInt("Speed").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("sNeed", 100);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("sNeed").ToString() + " DNA bodov";
                    }
                    break;

                case 2:
                    if(PlayerPrefs.GetInt("Coins") >= 100)
                    {
                        PlayerPrefs.SetInt("sLevel", 3);
                        speedSlider.value = PlayerPrefs.GetInt("sLevel");
                        PlayerPrefs.SetInt("Speed", 4);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 100);
                        levelSpeed.text = "Úroveň rýchlosti útoku: " + PlayerPrefs.GetInt("Speed").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("sNeed", 500);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("sNeed").ToString() + " DNA bodov";
                    }
                    break;

                case 3:
                    if(PlayerPrefs.GetInt("Coins") >= 500)
                    {
                        PlayerPrefs.SetInt("sLevel", 4);
                        speedSlider.value = PlayerPrefs.GetInt("sLevel");
                        PlayerPrefs.SetInt("Speed", 5);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 500);
                        levelSpeed.text = "Úroveň rýchlosti útoku: " + PlayerPrefs.GetInt("Speed").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("sNeed", 1500);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("sNeed").ToString() + " DNA bodov";
                    }
                    break;        

                case 4:
                    if(PlayerPrefs.GetInt("Coins") >= 1500)
                    {
                        PlayerPrefs.SetInt("sLevel", 5);
                        speedSlider.value = PlayerPrefs.GetInt("sLevel");
                        PlayerPrefs.SetInt("Speed", 6);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 1500);
                        levelSpeed.text = "Úroveň rýchlosti útoku: " + PlayerPrefs.GetInt("Speed").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        PlayerPrefs.SetInt("sNeed", 5000);
                        upgradeButtonCostDamage.text = "Potrebujete: " + PlayerPrefs.GetInt("sNeed").ToString() + " DNA bodov";
                    }
                    break;     

                case 5:
                    if(PlayerPrefs.GetInt("Coins") >= 5000)
                    {
                        PlayerPrefs.SetInt("sLevel", 6);
                        speedSlider.value = PlayerPrefs.GetInt("sLevel");
                        PlayerPrefs.SetInt("Speed", 7);
                        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 5000);
                        levelSpeed.text = "Úroveň rýchlosti útoku: " + PlayerPrefs.GetInt("Speed").ToString();
                        dna.text = PlayerPrefs.GetInt("Coins").ToString();
                        upgradeButtonCostDamage.text = "Maximálna rýchlosť útoku";
                    }
                    break;                     
            }
        }
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("dLevel", 0);
        PlayerPrefs.SetInt("sLevel", 0);
    }

    public void Money()
    {
        PlayerPrefs.SetInt("Coins", 10000);
    }
}
