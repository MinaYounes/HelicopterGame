using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3 : MonoBehaviour
{
    public static float speed = 8f;
    public static int damage = 10;
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

    // Destroy bullets when they collide with items
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if bullet touches enemy plane, metal crate, or airport destroy it
        if (collision.gameObject.CompareTag(ENEMY_TAG) || collision.gameObject.CompareTag(ENEMYLVL2_TAG) || collision.gameObject.CompareTag(METALBOX_TAG)
            || collision.gameObject.CompareTag(ENEMYLVL3_TAG) || collision.gameObject.CompareTag(AIRPORT_TAG))
        {
            // destroy bullet
            Destroy(gameObject);
        }
    }

    // will increase the damage of this bullet to 20
    public static void IncreaseDamage()
    {
        damage = 20;
    }

    // will increase the speed of this bullet to 9
    public static void IncreaseSpeed()
    {
        speed = 9f;
    }
}
