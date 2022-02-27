using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{   

    [SerializeField] float speed = 0.1f;

    void Start()
    {

    }

    void Update()
    {
        transform.position +=  -Vector3.right * Time.deltaTime * speed;
    }
}
