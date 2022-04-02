using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour
{

    // Code reused from Youtube video by Brackleys

    public float moveSpeed = 3.5f;
    public Rigidbody2D rb;
    bool facingRight = true;
    private string ENEMY_TAG = "Enemy";
    private string ENEMYLVL2_TAG = "Enemy2";
    private string AIRPORT_TAG = "Airport";
    Vector2 movement;
    private bool levelOneCompleted = false;
    private int levelOneProgress = 0;
    private bool levelTwoCompleted = false;
    private int levelTwoProgress = 0;

    void Update()
    {
        // Get X movement position
        movement.x = Input.GetAxisRaw("Horizontal");

        // If "D" pressed, plane faces right side
        if(movement.x > 0 && !facingRight)
        {
            Flip();
        }
        // If "A" pressed, plane faces left side
        else if (movement.x < 0 && facingRight)
        {
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

    // if player plane touches an enemy plane or airport, user dies
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(ENEMY_TAG) || collision.gameObject.CompareTag(ENEMYLVL2_TAG) || collision.gameObject.CompareTag(AIRPORT_TAG))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Death");
        }
    }

    // checks if level 1 is completed or not yet
    public void levelOneTracker()
    {
        levelOneProgress++;
        if(levelOneProgress == 12)
        {
            levelOneCompleted = true;
        }

        // if level one completed, calls coroutine to wait 2 sec and then change scenes
        if(levelOneCompleted)
        {
            StartCoroutine(waitFewSeconds());
        }
    }

    public void levelTwoTracker()
    {
        levelTwoProgress++;
        if (levelTwoProgress == 22)
        {
            levelTwoCompleted = true;
        }

        // if level one completed, calls coroutine to wait 2 sec and then change scenes
        if (levelTwoCompleted)
        {
            StartCoroutine(waitFewSeconds());
        }
    }
    // ADD LEVEL TO COROUTINEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE, reduce function tracker

    // Coroutine, will wait 2 seconds and change scene to level completed successfully
    IEnumerator waitFewSeconds()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("LevelSuccess");
    }
}
