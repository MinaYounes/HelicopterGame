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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.levelTwoTracker();
            Destroy(gameObject);

        }
    }
}
