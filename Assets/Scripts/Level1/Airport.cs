using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airport : MonoBehaviour
{
    private int health = 500;
    PlaneMovement plane;
    GameObject findPlane;
    public GameObject Explosion;
    private static bool mutex = false;
    private void Awake()
    {
        //findPlane = GameObject.FindGameObjectWithTag("Player");
    }

 


        // method will decrease health if touched by bullet
    public void DecreaseHealth(int damage)
    {
        health -= damage;

        // if health is 0, destroy the plane
        if (health <= 0 && !mutex)
        {
            mutex = true;

            //PlaneMovement.levelOneProgress++;
            //Debug.Log("airport lvltracker: " + PlaneMovement.levelOneProgress + " /12");
            findPlane = GameObject.FindGameObjectWithTag("Player");
            plane = findPlane.GetComponent<PlaneMovement>();
                plane.LevelTracker(1);
            mutex = false;


                //Debug.Log("airplmn, leveloneprog: " + PlaneMovement.levelOneProgress);
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            }
        }
    
}
