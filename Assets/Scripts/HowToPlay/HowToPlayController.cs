using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayController : MonoBehaviour
{
    // goes back to main menu when "Back" clicked
    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
