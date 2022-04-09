using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSuccessController : MonoBehaviour
{

    public static int SceneTracker = 1;

    // clicking store goes to store scene
    public void Store()
    {
        SceneManager.LoadScene("Shop");
    }

    // clicking save game saves data and goes back to main menu
    public void SaveGame()
    {  
        SaveSystem.SavePlayer();
        SceneManager.LoadScene("MainMenu");
    }

    // clicking next level goes to the next level
    public void NextLevel()
    {
	    DeathController.SceneTracker +=1;
	    SceneTracker++;
        EnemyPlane.level++;
        SceneManager.LoadScene(SceneTracker);
    }

    // if main menu pressed at ending scene, go to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        ShopController.coins = 0;
    }
}
