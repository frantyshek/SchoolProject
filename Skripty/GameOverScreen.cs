using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public Text score;

    void Start(){
        score.text = "Your score is: " + Score.scoreValue;
    }

    public void UpgradeButton(){
        SceneManager.LoadScene("Upgrade");
    }

    public void RestartButton(){
        SceneManager.LoadScene("Game");
        GameOver.IsNotGameOver = true;
    }

    public void MainMenuButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
