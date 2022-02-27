using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirusov : MonoBehaviour
{
    public GameObject Virus2HP;
    public GameObject Virus5HP;
    public GameObject Virus10HP;
    public GameObject Virus4;
    public GameObject Virus5;
    public GameObject Virus6;
    public GameObject Virus7;
    public GameObject Virus8;
    public GameObject Virus9;
    public GameObject Virus10;
    public float RespawnTime = 1f;


    void Start()
    {
        StartCoroutine(virusSpawnTimer());
    }

    IEnumerator virusSpawnTimer(){
        while(true){
            yield return new WaitForSeconds(RespawnTime);
            spawnVirus();   
        }
    }

    void spawnVirus(){
        //spawn pri skóre od 0 do 5
        if(Score.scoreValue <= 5){
            int roll = Random.Range(1, 100);   
            if (roll<= 100){
                GameObject a = Instantiate(Virus2HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
        }
        //spawn pri skóre od 6 do 10
                if(Score.scoreValue > 5){
                    if(Score.scoreValue <= 10){
            int roll = Random.Range(1, 100);   
            if (roll<= 70){
                GameObject a = Instantiate(Virus2HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
            if (roll>= 71){
                GameObject a = Instantiate(Virus5HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
            }
        }

        //spawn pri skóre od 11 do 25
                if(Score.scoreValue > 10){
                    if(Score.scoreValue <= 25){
            int roll = Random.Range(1, 100);   
            if (roll<= 55){
                GameObject a = Instantiate(Virus2HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
            if (roll >= 56){
                if(roll <= 85){
                GameObject a = Instantiate(Virus5HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
                }
            }
            if (roll>= 86){
                GameObject a = Instantiate(Virus10HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
            }

            
        }

                //spawn pri skóre od 26 
                if(Score.scoreValue > 25){
                    if(Score.scoreValue <= 99){
            int roll = Random.Range(1, 100);   
            if (roll<= 20){
                GameObject a = Instantiate(Virus2HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
            if (roll >= 21){
                if(roll <= 60){
                GameObject a = Instantiate(Virus5HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
                }
            }
            if (roll >= 61){
                if(roll <= 80){
                GameObject a = Instantiate(Virus10HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
                }
            }
             if (roll >= 81){
                GameObject a = Instantiate(Virus4) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
                    }
                }

            //spawn pri skóre od 100 
                if(Score.scoreValue > 99){
            int roll = Random.Range(1, 100);   
            if (roll<= 5){
                GameObject a = Instantiate(Virus2HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
            if (roll >= 6){
                if(roll <= 30){
                GameObject a = Instantiate(Virus5HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
                }
            }
            if (roll >= 31){
                if(roll <= 65){
                GameObject a = Instantiate(Virus10HP) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
                }
            }
             if (roll >= 66){
                if(roll <= 80){
                GameObject a = Instantiate(Virus4) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
                }
             }
             if (roll>= 81){
                GameObject a = Instantiate(Virus5) as GameObject;
                a.transform.position = new Vector2(10, Random.Range(-4, 4));
            }
            

            
        }

            if(Score.scoreValue >49){
                if(Score.scoreValue <= 100)
                {
                RespawnTime = 1f;
                }
            }

            if(Score.scoreValue > 100)
            {
                RespawnTime = 0.7f;
            }
        
    }
}
