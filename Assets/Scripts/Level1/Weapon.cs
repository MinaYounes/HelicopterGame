using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    // reference to bullet
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;

    // Update is called once per frame
    void Update()
    {
        // When the key "F" is pressed, shoot bullet 1 if game not paused
        if (Input.GetKeyDown(KeyCode.F) && PauseMenu.GameIsPaused == false)
        {
            Shoot(1);
        }

        // When the key "G" is pressed, shoot bullet 2 if game not paused
        if (Input.GetKeyDown(KeyCode.G) && PauseMenu.GameIsPaused == false)
        {
            Shoot(2);
        }

        // When the key "H" is pressed, shoot bullet 3 if game not paused
        if (Input.GetKeyDown(KeyCode.H) && PauseMenu.GameIsPaused == false)
        {
            Shoot(3);
        }
    }

    // instantiate either a missile, subsonic, or mach8
    void Shoot(int bulletNumber)
    {
        // shoot a missile
        if(bulletNumber == 1)
        {
            Instantiate(bulletPrefab1, firePoint.position, firePoint.rotation);
        }
        // shoot a subsonic
        if (bulletNumber == 2)
        {
            Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
        }
        // shoot a mach8
        if (bulletNumber == 3)
        {
            Instantiate(bulletPrefab3, firePoint.position, firePoint.rotation);
        }
    }
}
