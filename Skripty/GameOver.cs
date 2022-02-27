using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool IsNotGameOver = true;
    public GameObject GameOverScreen;

    void Start(){
        Time.timeScale = 1f;
        IsNotGameOver = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Virus"))
        {
            Time.timeScale = 0f;
        GameOverScreen.gameObject.SetActive(true);
        IsNotGameOver = false;
        }
    }
}
