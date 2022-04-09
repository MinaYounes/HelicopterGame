using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    public static int SceneTracker = 1;

    // restarts current level
    public void Restart()
    {
	    SceneManager.LoadScene(SceneTracker);
    }

    // goes to main menu 
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
