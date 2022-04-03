using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSuccessController : MonoBehaviour
{
    static int SceneTracker = 1;

    // clicking store goes to store scene
    public void Store()
    {
        //SceneManager.LoadScene("Store");
    }

    // clicking save game saves data
    public void SaveGame()
    {
        //TODO at the end
    }

    // clicking next level goes to the next level
    public void NextLevel()
    {
        SceneTracker++;
        SceneManager.LoadScene(SceneTracker);
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneTracker);
    }


    // if main menu pressed at ending scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
