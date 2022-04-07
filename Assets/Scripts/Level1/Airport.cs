using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airport : MonoBehaviour
{
    private int health = 200;
    PlaneMovement plane;
    GameObject findPlane;
    public GameObject Explosion;
    private void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag("Player");
    }

    // method will decrease health if touched by bullet
    public void DecreaseHealth(int damage)
    {
        health -= damage;

        // if health is 0, destroy the plane
        if (health <= 0)
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.LevelTracker(1);
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
