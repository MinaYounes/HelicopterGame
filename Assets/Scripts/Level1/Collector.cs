using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    private void onTriggerEnter2D(Collider2D collision)
    {
            Destroy(collision.gameObject);
    }
}

