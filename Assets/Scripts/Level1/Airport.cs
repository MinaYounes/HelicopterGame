using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airport : MonoBehaviour
{
    private int health = 600;
    PlaneMovement plane;
    GameObject findPlane;
    public GameObject Explosion;
    private void Awake()
    {
        // find the gameobject of the player
        findPlane = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        // if health is 0, destroy airport
        if (health <= 0)
        {
            DestroyObject();
        }
    }

    // if collision happens
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if hit by missile, reduce health of airport
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= Bullet.damage;
        }
        // if hit by subsonic, reduce health of airport
        else if (collision.gameObject.CompareTag("Bullet2"))
        {
            health -= Bullet2.damage;
        }
        // if hit by mach8, reduce health of airport
        else if (collision.gameObject.CompareTag("Bullet3"))
        {
            health -= Bullet3.damage;
        }
    }

    // method will destroy an airport once health is 0 or below
    public void DestroyObject()
    {
        // finds object and increases the level progress (LevelTracker)
        plane = findPlane.GetComponent<PlaneMovement>();
        plane.LevelTracker(1);
        
        // explosion animation and airport disappears
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
}
