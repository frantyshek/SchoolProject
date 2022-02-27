using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                if (GameIsPaused)
                {
                    Resume();
                } else if(GameOver.IsNotGameOver)
                {
                    Pause();
                }   
        }
    
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameOver.IsNotGameOver = true;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        GameOver.IsNotGameOver = false;
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    
}
