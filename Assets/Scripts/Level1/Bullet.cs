using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 7f;
    public Rigidbody2D rb;
    private string AIRPORT_TAG = "Airport";
    private string ENEMY_TAG = "Enemy";
    private string ENEMYLVL2_TAG = "Enemy2";
    private string ENEMYLVL3_TAG = "Enemy3";
    private string METALBOX_TAG = "MetalBox";
   

    // Start is called before the first frame update
    void Start()
    {
        // Movement of bullet
        rb.velocity = transform.right * speed;
    }
    
    // Destroy bullets when they collide with enemy planes or airports
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;
        // if bullet touches enemy plane or metal crate destroy it
        if (collision.gameObject.CompareTag(ENEMY_TAG) || collision.gameObject.CompareTag(ENEMYLVL2_TAG) || collision.gameObject.CompareTag(METALBOX_TAG)
            || collision.gameObject.CompareTag(ENEMYLVL3_TAG))
        {
            // destroy bullet if touches enemy plane
            Destroy(gameObject);
            // decrease health of enemy plane if touched by bullet
            if (collision.gameObject.CompareTag(ENEMY_TAG))
            {
                other.GetComponent<EnemyPlane>().DecreaseHealth(1);
            }
            else if(collision.gameObject.CompareTag(ENEMYLVL2_TAG))
            {
                other.GetComponent<EnemyPlane>().DecreaseHealth(2);
            }
            else if(collision.gameObject.CompareTag(ENEMYLVL3_TAG))
            {
                other.GetComponent<EnemyPlane>().DecreaseHealth(3);
            }
        }
        // if bullet touches airport
        if (collision.gameObject.CompareTag(AIRPORT_TAG))
        {
            // destroy bullet if touches airport
            Destroy(gameObject);
            // decrease health of airport if touched by bullet
            other.GetComponent<Airport>().DecreaseHealth();
        }
    }

    //Code destroys enemies or whatever touches bullet
    /*
     private void OnTriggerEnter2D(Collider2D collision)
     {
         Destroy(collision.gameObject);
     }*/
}
