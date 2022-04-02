using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private string PLAYER_TAG = "Player";
    private int guysPickedUp = 0;
    PlaneMovement plane;
    GameObject findPlane;
    private bool guysRescued = false;

    void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag(PLAYER_TAG);
    }

    // if building gets touched by player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            guysPickedUp = plane.PickedUpGetter();

            if(guysPickedUp == 7 && guysRescued == false)
            {
                plane.LevelTracker(2);
                guysRescued = true;
            }
        }
    }
}
