using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code inspired by freeCodeCamp.org
public class EnemySpawnerLvl2 : MonoBehaviour
{
    int enemyCounter = 0;
    int enemyLimit = 15;

    [SerializeField]
    private GameObject[] planeReference;

    private GameObject spawnedPlane;

    [SerializeField]
    private Transform rightBottom2, rightBottom3, rightTop2, rightTop3, rightBottom1, rightTop1;

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
            // Spawn monster every second
            yield return new WaitForSeconds(1);

            randomIndex = Random.Range(0, planeReference.Length);
            randomSide = Random.Range(0, 7);
            // Creates copy of plane
            spawnedPlane = Instantiate(planeReference[randomIndex]);

            // Spawn enemy plane in top right 1 position
            if (randomSide == 0)
            {
                spawnedPlane.transform.position = rightTop1.position;
                PlaneSpawner();
            }
            // Spawn enemy plane in top right 2 position
            else if (randomSide == 1)
            {
                spawnedPlane.transform.position = rightTop2.position;
                PlaneSpawner();
            }
            // Spawn enemy plane in top right 3 position
            else if (randomSide == 2)
            {
                spawnedPlane.transform.position = rightTop3.position;
                PlaneSpawner();
            }
            // Spawn enemy plane in bottom right 1 position
            else if (randomSide == 3)
            {
                spawnedPlane.transform.position = rightBottom1.position;
                PlaneSpawner();
            }
            // Spawn enemy plane in bottom right 2 position
            else if (randomSide == 4)
            {
                spawnedPlane.transform.position = rightBottom2.position;
                PlaneSpawner();
            }
            // Spawn enemy plane in bottom right 3 position
            else
            {
                spawnedPlane.transform.position = rightBottom3.position;
                PlaneSpawner();
            }
            enemyCounter++;
        }

        // function will make plane have a speed between 3 and 4
        void PlaneSpawner()
        {
            // Speed of spawned plane will be random number between 2 and 3
            spawnedPlane.GetComponent<EnemyPlane>().speed = -Random.Range(2, 4);
            // Flips planes coming from the right side
            spawnedPlane.transform.localScale = new Vector3(-0.15f, 0.15f, 0.15f);
        }
    }
}

