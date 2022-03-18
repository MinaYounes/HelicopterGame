using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 7f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Movement of bullet
        rb.velocity = transform.right * speed;
    }

    // When collision happens
     void OnTriggerEnter2D(Collider2D hitInfo)
     {
         //2d shooting unity 9:50
     } 
}
