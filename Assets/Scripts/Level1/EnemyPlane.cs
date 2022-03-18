using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{

    [HideInInspector]
    public float speed;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        // Enemy speed
        //speed = 3f;
    }

    void FixedUpdate()
    {
        // Makes enemy planes move on X axis while staying on same Y point
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}
