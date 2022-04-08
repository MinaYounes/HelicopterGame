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

        Bullet.speed = 6f;
        Bullet.damage = 20;

        Bullet2.speed = 4.5f;
        Bullet2.damage = 30;

        Bullet3.speed = 8f;
        Bullet3.damage = 10;

        if (ReadInput.emailEntered == true)
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
