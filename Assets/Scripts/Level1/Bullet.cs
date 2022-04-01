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
    
    // Destroy bullets when they collide with enemy planes
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // destroy bullet if touches enemy plane
            Destroy(gameObject);
            // decrease health of enemy plane if touched by bullet
            other.GetComponent<EnemyPlane>().decreaseHealth(); 
        }
    }

    //Code destroys enemies or whatever touches bullet
    /*
     private void OnTriggerEnter2D(Collider2D collision)
     {
         Destroy(collision.gameObject);
     }*/
}
