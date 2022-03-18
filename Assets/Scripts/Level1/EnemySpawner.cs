using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code inspired by freeCodeCamp.org
public class EnemySpawner : MonoBehaviour
{
    int enemyCounter = 0;
    int enemyLimit = 6;

    [SerializeField]
    private GameObject[] planeReference;

    private GameObject spawnedPlane;

    [SerializeField]
    private Transform leftPos, bottomLeftPos, rightPos, bottomRightPos;

    // Random plane spawned
    private int randomIndex;
    // Spawns random side
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPlanes());
    }

    // Coroutine 
    IEnumerator SpawnPlanes()
    {
        // Checks enemy spawned counter compared to limit set
        while(enemyCounter < enemyLimit)
        {
            // Spawn monster every 2 to 3 seconds
            yield return new WaitForSeconds(Random.Range(2, 4));

            randomIndex = Random.Range(0, planeReference.Length);
            randomSide = Random.Range(0, 4);
            // Creates copy of plane
            spawnedPlane = Instantiate(planeReference[randomIndex]);

            // Spawn enemy plane in top left position
            if (randomSide == 0)
            {
                spawnedPlane.transform.position = leftPos.position;
                // Speed of spawned plane will be random number between 1 and 2
                spawnedPlane.GetComponent<EnemyPlane>().speed = Random.Range(1, 3);

            }
            // Spawn enemy plane in bottom left position
            else if (randomSide == 1)
            {
                spawnedPlane.transform.position = bottomLeftPos.position;
                // Speed of spawned plane will be random number between 1 and 2
                spawnedPlane.GetComponent<EnemyPlane>().speed = Random.Range(1, 3);
            }
            // Spawn enemy plane in top right position
            else if (randomSide == 2)
            {
                spawnedPlane.transform.position = rightPos.position;
                // Speed of spawned plane will be random number between 1 and 2
                spawnedPlane.GetComponent<EnemyPlane>().speed = -Random.Range(1, 3);
                // Flips planes coming from the right side
                spawnedPlane.transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
            }
            // Spawn enemy plane in bottom right position
            else
            {
                spawnedPlane.transform.position = bottomRightPos.position;
                // Speed of spawned plane will be random number between 1 and 2
                spawnedPlane.GetComponent<EnemyPlane>().speed = -Random.Range(1, 3);
                // Flips planes coming from the right side
                spawnedPlane.transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
            }
            enemyCounter++;
        }
    }
}

