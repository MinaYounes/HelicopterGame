using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 7f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Movement of bullet
        rb.velocity = transform.right * speed;
    }

    // Destroy bullets when they collide with something else than other bullets
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!(collision.gameObject.CompareTag("Bullet")))
        {
            Destroy(gameObject);
        }
    }

    //Code destroys enemies or whatever touches bullet
    /*
     private void OnTriggerEnter2D(Collider2D collision)
     {
         Destroy(collision.gameObject);
     }*/
}
