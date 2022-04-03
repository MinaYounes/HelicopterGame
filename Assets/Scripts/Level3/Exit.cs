using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    PlaneMovement plane;
    GameObject findPlane;
    private string PLAYER_TAG = "Player";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag(PLAYER_TAG);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            plane = findPlane.GetComponent<PlaneMovement>();
            plane.LevelTracker(3);
        }
    }
}
