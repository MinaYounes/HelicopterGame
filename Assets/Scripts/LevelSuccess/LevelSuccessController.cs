using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSuccessController : MonoBehaviour
{
    private int SceneTracker = 2;

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
        
        //SceneManager.LoadScene(track);
        
    }

    // if main menu pressed at ending scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
