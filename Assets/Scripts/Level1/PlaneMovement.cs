using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour
{
    // Code inspired by youtuber Brackleys

    public float moveSpeed = 3.5f;
    public Rigidbody2D rb;
    bool facingRight = true;
    private string ENEMY_TAG = "Enemy";
    private string ENEMYLVL2_TAG = "Enemy2";
    private string ENEMYLVL3_TAG = "Enemy3";
    private string AIRPORT_TAG = "Airport";
    private string METALBOX_TAG = "MetalBox";
    private string LIMIT_TAG = "Limit";
    Vector2 movement;
    private bool levelOneCompleted = false;
    public int levelOneProgress = 0;
    private bool levelTwoCompleted = false;
    private int levelTwoProgress = 0;
    private int guysPickedUp = 0;
    private bool levelThreeCompleted = false;
    private int levelThreeProgress = 0;

    void Update()
    {
        // Get X movement position
        movement.x = Input.GetAxisRaw("Horizontal");

        // If "D" pressed, plane faces right side when game is not paused
        if(movement.x > 0 && !facingRight && PauseMenu.GameIsPaused == false)
        {
            Flip();
        }
        // If "A" pressed, plane faces left side when game is not paused
        else if (movement.x < 0 && facingRight && PauseMenu.GameIsPaused == false)
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

    // if player plane touches ground, an enemy plane, airport, metal crates, or exit sign at lvl3, destroy the player's plane
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(ENEMY_TAG)|| collision.gameObject.CompareTag(ENEMYLVL2_TAG) || collision.gameObject.CompareTag(AIRPORT_TAG) 
            || collision.gameObject.CompareTag(METALBOX_TAG) || collision.gameObject.CompareTag(ENEMYLVL3_TAG) || collision.gameObject.CompareTag(LIMIT_TAG))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Death");
        }
    }
    
    // checks if different levels are completed or not yet
    public void LevelTracker(int level)
    {
        if (level == 1)
        {
            // increase progress tracker of level 1
            levelOneProgress++;
            
            // if 12 tasks completed, level one is completed
            if (levelOneProgress == 12)
            {
                levelOneCompleted = true;
            }
        }
        else if(level == 2)
        {
            // increase progress tracker of level 2
            levelTwoProgress++;

            // if 23 tasks completed, level two is completed
            if (levelTwoProgress == 23)
            {
                levelTwoCompleted = true;
            }
        }
        else if(level == 3)
        {
            // increase progress tracker of level 3
            levelThreeProgress++;

            // if 7 tasks completed, level three is completed
            if (levelThreeProgress == 7)
            {
                levelThreeCompleted = true;
            }
        }
        // if level one or two completed, calls coroutine to wait 2 sec and then change scenes
        if (levelOneCompleted || levelTwoCompleted)
        {
            StartCoroutine(WaitFewSeconds()); 
        }

         // if level three completed, game is finished
        if (levelThreeCompleted)
        {
            StartCoroutine(WaitThenEnd());
        }
    }   

    // Coroutine, will wait 2 seconds and change scene to level completed successfully while increasing coins by 100
    IEnumerator WaitFewSeconds()
    {
        yield return new WaitForSeconds(2);
	    ShopController.coins += 100;
        SceneManager.LoadScene("LevelSuccess");
    }

    // Coroutine will wait 2 seconds then display the end scene
    IEnumerator WaitThenEnd()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("FinishedGame");
    }
    
    // increases number of guys rescued
    public void PickedUp()
    {
        guysPickedUp++;
    }

    // returns number of guys picked up
    public int PickedUpGetter()
    {
        return guysPickedUp;
    }

}
