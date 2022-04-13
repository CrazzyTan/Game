using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour{

    public float speed = 20f;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Start()
    {
        rb.velocity = transform.right * speed;
        }
        
    
}
