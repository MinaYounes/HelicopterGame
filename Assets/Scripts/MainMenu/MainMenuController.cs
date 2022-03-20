using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // clicking new game goes to level 1 game scene
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
