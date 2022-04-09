using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guys : MonoBehaviour
{
    PlaneMovement plane;
    GameObject findPlane;
    private string PLAYER_TAG = "Player";

    private void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag(PLAYER_TAG);
    }

    // if collision with player's plane, guy got picked up and destroy the guy object while increasing progress of level 2
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.LevelTracker(2);
            plane.PickedUp();
            Destroy(gameObject);

        }
    }
}
