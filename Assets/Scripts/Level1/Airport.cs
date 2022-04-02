using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airport : MonoBehaviour
{
    private int health = 100;
    PlaneMovement plane;
    GameObject findPlane;
    public GameObject Explosion;
    private void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag("Player");
    }

    // method will decrease health if touched by bullet
    public void decreaseHealth()
    {
        health -= 10;

        // if health is 0, destroy the plane
        if (health <= 0)
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.levelOneTracker();
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
