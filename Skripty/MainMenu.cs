using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    [SerializeField] GameObject settingsScreen;

    public void PlayGame ()
    {
        SceneManager.LoadScene("Game");
        GameOver.IsNotGameOver = true;
    }

    public void Upgrade(){
        SceneManager.LoadScene("Upgrade");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Settings()
    {
        settingsScreen.SetActive(true);
    }
}

