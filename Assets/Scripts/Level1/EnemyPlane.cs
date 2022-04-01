using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{

    [HideInInspector]
    public float speed;
    private Rigidbody2D rb;
    private string LIMIT_TAG = "Limit";
    private string AIRPORT_TAG = "Airport";
    private SpriteRenderer sr;
    private int health = 100;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }
    // In case of collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When enemy plane collides with walls, flip plane
        if (collision.gameObject.CompareTag(LIMIT_TAG) || collision.gameObject.CompareTag(AIRPORT_TAG))
        {
            // flip plane's direction on X axis
            sr.flipX = !sr.flipX;
            // change speed to go other way
            speed = -speed;
        }
    }

    void FixedUpdate()
    {
        // Makes enemy planes move on X axis while staying on same Y point
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    // method will decrease health if touched by bullet
    public void decreaseHealth()
    {
        health -= 20;

        // if health is 0, destroy the plane
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
