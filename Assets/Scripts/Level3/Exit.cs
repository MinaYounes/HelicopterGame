using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    PlaneMovement plane;
    GameObject findPlane;
    private string PLAYER_TAG = "Player";
  
    private void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag(PLAYER_TAG);
    }

    // if plane touches exit, increase progress by one of level 3
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.LevelTracker(3);
	    ExitObj.exited = true;
        }
    }
}
