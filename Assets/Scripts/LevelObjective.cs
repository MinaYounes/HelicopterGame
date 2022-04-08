using UnityEngine;
using System.Collections;

public class LevelObjective : MonoBehaviour
{
    public float time = 5f; // seconds to have text displayed

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}