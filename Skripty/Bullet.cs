using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public int damage = 1;

    void Start()
    {
        damage = PlayerPrefs.GetInt("Damage");
        if(damage == 0)
        {
            damage = 1;
        }
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {


        Virus virus = hitInfo.GetComponent<Virus>();
        if(virus != null)
        {
            virus.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
