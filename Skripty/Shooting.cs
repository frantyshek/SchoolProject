using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject Strela;
    public float attackSpeed = 1f;
    private float TimeUntilAttack = 0f;

    void Start()
    {
        attackSpeed = PlayerPrefs.GetInt("Speed");
        if(attackSpeed == 0)
        {
            attackSpeed = 1f;
        }

        if(PlayerPrefs.GetInt("Speed") == 1)
        {
            attackSpeed = 1f;
        }

        switch(PlayerPrefs.GetInt("Speed"))
        {
            case 2:
                attackSpeed = 0.9f;
                break;

            case 3:
                attackSpeed = 0.8f;
                break;

            case 4:
                attackSpeed = 0.7f;
                break;

            case 5:
                attackSpeed = 0.6f;
                break;
            
            case 6:
                attackSpeed = 0.5f;
                break;

            case 7:
                attackSpeed = 0.4f;
                break;                
        }
    }

    void Update()
    {
        if(GameOver.IsNotGameOver){
            Shoot();
        }        

    }

    public void Shoot(){
        if(Input.GetButton("Jump") && TimeUntilAttack < Time.time)
        {
            TimeUntilAttack = Time.time + attackSpeed;
            Instantiate(Strela, FirePoint.position, FirePoint.rotation);
        }   
    }
}
