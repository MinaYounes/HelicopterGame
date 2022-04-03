using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code inspired by freeCodeCamp.org
public class EnemySpawnerLvl3 : MonoBehaviour
{
    int enemyCounter = 0;
    int enemyLimit = 6;

    [SerializeField]
    private GameObject[] planeReference;

    private GameObject spawnedPlane;

    [SerializeField]
    private Transform leftMidPos, leftBottomPos, rightMidPos, rightBottomPos, leftTopPos, rightTopPos;

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
        while (enemyCounter < enemyLimit)
        {
            // Spawn all enemy planes when level starts
            yield return new WaitForSeconds(0);

            // creates a plane for each spawner, no longer random like previous levels
            for (int i = 0; i < 6; i++)
            {
                // random plane appears
                randomIndex = Random.Range(0, planeReference.Length);
                // creates a copy of the plane
                spawnedPlane = Instantiate(planeReference[randomIndex]);

                // Spawn enemy plane in top right position
                if (i == 0)
                {
                    spawnedPlane.transform.position = rightTopPos.position;
                    PlaneSpawnFromRight();

                }
                // Spawn enemy plane in middle right position
                else if (i == 1)
                {
                    spawnedPlane.transform.position = rightMidPos.position;
                    PlaneSpawnFromRight();
                }
                // Spawn enemy plane in low right position
                else if (i == 2)
                {
                    spawnedPlane.transform.position = rightBottomPos.position;
                    PlaneSpawnFromRight();
                }
                // Spawn enemy plane in top left position
                else if (i == 3)
                {
                    spawnedPlane.transform.position = leftTopPos.position;
                    PlaneSpawnFromLeft();
                }
                // Spawn enemy plane in middle left position
                else if (i == 4)
                {
                    spawnedPlane.transform.position = leftMidPos.position;
                    PlaneSpawnFromLeft();
                }
                // Spawn enemy plane in bottom left position
                else
                {
                    spawnedPlane.transform.position = leftBottomPos.position;
                    PlaneSpawnFromLeft();
                }
                enemyCounter++;
            }
        }
    }

    // when a plane spawns from right, set speed and direction
    void PlaneSpawnFromRight()
    {
        // Speed of spawned plane will be random number between 3 and 4
        spawnedPlane.GetComponent<EnemyPlane>().speed = -Random.Range(3, 5);
        // Flips planes coming from the right side
        spawnedPlane.transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
    }

    // when a plane spawns from left, set speed 
    void PlaneSpawnFromLeft()
    {
        // Speed of spawned plane will be random number between 3 and 4
        spawnedPlane.GetComponent<EnemyPlane>().speed = Random.Range(3, 5);
    }
}

