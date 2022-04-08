using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSuccessController : MonoBehaviour
{

    static int SceneTracker = 1;

   /* public void GoBack()
    {
        SceneManager.LoadScene("LevelSuccess");
    } */

    // clicking store goes to store scene
    public void Store()
    {
        SceneManager.LoadScene("Shop");
    }

    // clicking save game saves data
    public void SaveGame()
    {
        //TODO at the end
    }

    // clicking next level goes to the next level
    public void NextLevel()
    {
	    DeathController.SceneTracker +=1;
	    SceneTracker++;
        SceneManager.LoadScene(SceneTracker);
        
    }

    // if main menu pressed at ending scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        ShopController.coins = 0;
    }
}
