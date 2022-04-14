using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // deactivate the pause menu at start
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        // if the P key is pushed
        if(Input.GetKeyDown(KeyCode.P))
        {
            // if game was paused, resume the game
            if(GameIsPaused)
            {
                Resume();
            }
            // if game was not paused, pause it
            else
            {
                Pause();
            }
        }
    }

    // will resume the game by changing the timescale back to 1
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // pauses the game by changing timescale to 0
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
