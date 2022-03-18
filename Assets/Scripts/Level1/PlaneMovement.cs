using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{

    // Code reused from Youtube video by Brackleys

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private SpriteRenderer sr;
    bool facingRight = true;
    Vector2 movement;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        // Get X movement position
        movement.x = Input.GetAxisRaw("Horizontal");

        // If "D" pressed, plane faces right side
        if(movement.x > 0 && !facingRight)
        {
            //sr.flipX = false;
            //transform.Rotate(0f, 0f, 0f);
            flip();
        }
        // If "A" pressed, plane faces left side
        else if (movement.x < 0 && facingRight)
        {
            //sr.flipX = true;
            //transform.Rotate(0f, 180f, 0f);
            flip();
        }

        // Get Y movement position
        movement.y = Input.GetAxisRaw("Vertical");
    }
  
    void FixedUpdate()
    {
        // Move with certain speed
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    // function flips plane 180 degrees
    private void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);

    }


}
