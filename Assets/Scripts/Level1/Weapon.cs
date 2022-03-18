using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    // reference to bullet
    public GameObject bulletPrefab;
    
    // Update is called once per frame
    void Update()
    {
        // When the key "F" is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
