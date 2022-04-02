using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSuccessController : MonoBehaviour
{
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

    // clicking next level goes from lvl1 to lvl2
    public void NextLevel1to2()
    {
        //uncomment out when level 2 done
        //SceneManager.LoadScene("Level1");
    }
}
