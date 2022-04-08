using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    public static int SceneTracker = 1;

    public void Restart()
    {
	    SceneManager.LoadScene(SceneTracker);
    }

}
