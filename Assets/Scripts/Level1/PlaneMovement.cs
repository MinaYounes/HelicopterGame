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

    // if player plane touches ground, an enemy plane, airport, metal crates, or exit sign at lvl3
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
            levelOneProgress++;
            Debug.Log("PLNMVTprogress LVl1: " + levelOneProgress + " /12");
            if (levelOneProgress == 12)
            {
                levelOneCompleted = true;
            }
        }

        else if(level == 2)
        {
            levelTwoProgress++;
            Debug.Log("progress LVL2: " + levelTwoProgress + " /23");
            if (levelTwoProgress == 23)
            {
                levelTwoCompleted = true;
            }
        }

        else if(level == 3)
        {
            levelThreeProgress++;
            Debug.Log("progress LVl3: " + levelThreeProgress + " /7");
            if(levelThreeProgress == 7)
            {
                levelThreeCompleted = true;
            }
        }
        // if level one or two completed, calls coroutine to wait 2 sec and then change scenes
        if (levelOneCompleted || levelTwoCompleted)
        {
            Debug.Log("LEveloneCompleted || level2Completed");
            StartCoroutine(WaitFewSeconds());
            
        }

         // if level three completed, game is finished
        if (levelThreeCompleted)
        {
            Debug.Log("Level3completed");
            StartCoroutine(WaitThenEnd());
            
        }
    }   

    // Coroutine, will wait 2 seconds and change scene to level completed successfully
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
    

    public void PickedUp()
    {
        guysPickedUp++;
    }

    public int PickedUpGetter()
    {
        return guysPickedUp;
    }

}
