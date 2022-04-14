using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private string METALBOX_TAG = "MetalBox";
    private string BULLET_TAG = "Bullet";
    private string BULLET2_TAG = "Bullet2";
    private string BULLET3_TAG = "Bullet3";

    private SpriteRenderer sr;
    private int health = 100;
    PlaneMovement plane;
    GameObject findPlane;
    public GameObject Explosion;
    public static int level = 1;
 
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        findPlane = GameObject.FindGameObjectWithTag(PLAYER_TAG);

    }
    private void Update()
    {
        // if health of an enemy plane is below 0, destroy object
        if(health <= 0)
        {
            DestroyObject(level);
	    PlaneCount.count +=1;
	    PlaneCount2.count +=1;
	    PlaneCount3.count +=1;
        }
    }
    // In case of collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When enemy plane collides with walls, airport, guys, building, or metal crate flip plane
        if (collision.gameObject.CompareTag(LIMIT_TAG) || collision.gameObject.CompareTag(AIRPORT_TAG) || collision.gameObject.CompareTag(BUILDING_TAG)
            || collision.gameObject.CompareTag(METALBOX_TAG))
        {
            // flip plane's direction on X axis
            sr.flipX = !sr.flipX;
            // change speed to go other way
            speed = -speed;
        }

        // if enemy plane touches one of the guys to rescue, level failed
        if(collision.gameObject.CompareTag(GUYS_TAG))
        {
            SceneManager.LoadScene("Death");
        }

        // if enemy plane touches user helicopter, destroy enemy plane and make explosion effect
        if(collision.gameObject.CompareTag(PLAYER_TAG))
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // if collision happens
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // reduce health if enemyplane touched by missile
        if (collision.gameObject.CompareTag(BULLET_TAG))
        {
            health -= Bullet.damage;
        }
        // reduce health if enemyplane touched by subsonic
        else if (collision.gameObject.CompareTag(BULLET2_TAG))
        {
            health -= Bullet2.damage;
        }
        // reduce health if enemyplane touched by mach 8
        else if (collision.gameObject.CompareTag(BULLET3_TAG))
        {
            health -= Bullet3.damage;
        }
    } 

    void FixedUpdate()
    {
        // Makes enemy planes move on X axis while staying on same Y point
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
   

    // method will destroy the object
    public void DestroyObject(int level) 
    {

        ExplodeAndDestroy();
        // increase progress tracker of level 1
        if (level == 1)
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.LevelTracker(1);
        }
        // increase progress tracker of level 2
        else if (level == 2)
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.LevelTracker(2);
        }
        // increase progress tracker of level 3
        else if (level == 3)
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.LevelTracker(3);
        }
    }
    
    // function will make an explosion effect and destroy the object
    void ExplodeAndDestroy()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
