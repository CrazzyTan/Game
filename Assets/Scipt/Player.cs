using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject deadExplosion;

    Rigidbody2D rb;
    float dirX;

    private Shake shake;


    // Start is called before the first frame update
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent <Shake>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void dead()
    {
        Instantiate(deadExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shake.CamShake();
        if(collision.tag =="Obstacle")
        {
            dead();
        }
    }
}


