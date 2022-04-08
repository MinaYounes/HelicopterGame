using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airport : MonoBehaviour
{
    private int health = 800;
    PlaneMovement plane;
    GameObject findPlane;
    public GameObject Explosion;
    private void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag("Player");
    }


    private void Update()
    {
        if (health <= 0)
        {
            DecreaseHealth();
        }
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            //DecreaseHealth(level); //Bullet.damage);
            health -= Bullet.damage;
        }
        else if (collision.gameObject.CompareTag("Bullet2"))
        {
            //DecreaseHealth(level); //Bullet2.damage);
            health -= Bullet2.damage;
        }
        else if (collision.gameObject.CompareTag("Bullet3"))
        {
            //DecreaseHealth(level);//Bullet3.damage);
            health -= Bullet3.damage;
        }
    }




    // method will decrease health if touched by bullet
    public void DecreaseHealth()
    {
        plane = findPlane.GetComponent<PlaneMovement>();
        plane.LevelTracker(1);
 
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
}
