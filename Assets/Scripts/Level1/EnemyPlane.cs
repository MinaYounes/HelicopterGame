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
    private string PLAYER_TAG = "Player";
    private string BUILDING_TAG = "Building";
    private string GUYS_TAG = "Guys";

    private SpriteRenderer sr;
    private int health = 100;
    PlaneMovement plane;
    GameObject findPlane;
    public GameObject Explosion;
    


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        findPlane = GameObject.FindGameObjectWithTag(PLAYER_TAG);

    }
    // In case of collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When enemy plane collides with walls, airport, guys, or building flip plane
        if (collision.gameObject.CompareTag(LIMIT_TAG) || collision.gameObject.CompareTag(AIRPORT_TAG) || collision.gameObject.CompareTag(BUILDING_TAG) 
            || collision.gameObject.CompareTag(GUYS_TAG))
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
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.levelOneTracker();
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void decreaseHealthLvl2()
    {
        health -= 20;

        // if health is 0, destroy the plane
        if (health <= 0)
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.levelTwoTracker();
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
