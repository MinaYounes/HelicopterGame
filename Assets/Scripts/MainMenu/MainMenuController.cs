using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // clicking new game goes to level 1 game scene
    public void PlayGame()
    {
        EnemyPlane.level = 1;
        if(ReadInput.emailEntered == true)
        {
            ShopController.coins += 100;
        }
	    else
        {
            ShopController.coins = 0;
        }
	    DeathController.SceneTracker = 1;
        SceneManager.LoadScene("Level1");
    }

    //TODO: scene manager for load game. Do when multiple scenes/levels added
}
