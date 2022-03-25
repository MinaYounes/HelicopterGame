using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour
{

    // Code reused from Youtube video by Brackleys

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    //private SpriteRenderer sr;
    bool facingRight = true;
    private string ENEMY_TAG = "Enemy";
    Vector2 movement;


    private void Awake()
    {
        //sr = GetComponent<SpriteRenderer>();
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
            Flip();
        }
        // If "A" pressed, plane faces left side
        else if (movement.x < 0 && facingRight)
        {
            //sr.flipX = true;
            //transform.Rotate(0f, 180f, 0f);
            Flip();
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
    private void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Death");
        }
    }
}
