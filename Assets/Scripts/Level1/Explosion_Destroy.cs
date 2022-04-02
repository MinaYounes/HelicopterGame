using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Destroy : MonoBehaviour
{
    // destroys explosion object
    private void FixedUpdate()
    {
        Destroy(gameObject, 3.0f);
    }
}
