using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;
    
    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        // Find player by its tag
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // If player destroyed. don't access it
        if (!player)
        {
            return;
        }

        // Current camera position
        tempPos = transform.position;
        // Sets camera's X position to player's X position
        tempPos.x = player.position.x;

        // Sets limit on the left of the camera following player 
        if(tempPos.x < minX)
        {
            tempPos.x = minX;
        }

        // Sets limit on the right of the camera following player 
        if (tempPos.x > maxX)
        {
            tempPos.x = maxX;
        }

        // Set Camera's position
        transform.position = tempPos;
    }
}
