using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    public int health = 2;
    public Rigidbody2D rb;
    public float speed = 3f;
    public GameObject DeadParticles;
    public int plusoveScore = 1;
    public int maxHealth = 2;
    public SliderHP HealthBar;

    void Start(){
        rb.velocity = new Vector2(-speed,0);
        HealthBar.SetHealth(health, maxHealth);
    }

    public void TakeDamage (int damage)
    {
        health -= damage;
        HealthBar.SetHealth(health, maxHealth);
        if(health <= 0){
            Score.scoreValue += plusoveScore;
            GameObject deadEffect = Instantiate(DeadParticles, transform.position, Quaternion.identity);
            Destroy(deadEffect, 3f);
            Destroy(gameObject);
        }
    }

}
