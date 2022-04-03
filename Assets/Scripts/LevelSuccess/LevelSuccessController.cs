using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSuccessController : MonoBehaviour
{
    private int SceneTracker = 2;
    int track;
    PlaneMovement plane;
    GameObject findPlane;
    int currentScenePlane;

    private void Awake()
    {
        findPlane = GameObject.FindGameObjectWithTag("Player");

        plane = findPlane.GetComponent<PlaneMovement>();
        //currentScenePlane =  plane.SceneGetter();

    }

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
        currentScenePlane = plane.SceneGetter();
        if (currentScenePlane == 1)
        {
            SceneManager.LoadScene(2);
        }
        else if(currentScenePlane == 2)
        {
            SceneManager.LoadScene(3);
        }
       
        //SceneManager.LoadScene(track);
        
    }
}
