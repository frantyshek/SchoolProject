using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeMenu : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene("Game");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

}
