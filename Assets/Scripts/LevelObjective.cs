using UnityEngine;
using System.Collections;

public class LevelObjective : MonoBehaviour
{
    public float time = 5f; // seconds to have text displayed

    // will display the level objectives in the beginning of each level 
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}