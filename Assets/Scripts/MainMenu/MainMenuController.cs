using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    private Text bonusCoins;

    private void Update()
    {
        // if the email is entered or was entered, "+100 coins" continues to display on main menu
        if(ReadInput.emailEntered == true)
        {
            bonusCoins = GameObject.Find("ThanksForEmail").GetComponent<Text>();
            bonusCoins.text = "+100 coins!";
        }
    }

    // clicking new game goes to level 1 game scene
    public void PlayGame()
    {
        // reset game components
        EnemyPlane.level = 1;

        Bullet.speed = 6f;
        Bullet.damage = 20;

        Bullet2.speed = 4.5f;
        Bullet2.damage = 30;

        Bullet3.speed = 8f;
        Bullet3.damage = 10;

        // if email is set to true, always give 100 bonus coins when game restarts
        if (ReadInput.emailEntered == true)
        {
            ShopController.coins += 100;
        }
        // if email not given, no bonus coins
	    else
        {
            ShopController.coins = 0;
        }
	    DeathController.SceneTracker = 1;
        SceneManager.LoadScene("Level1");
    }

    //TODO: scene manager for load game. Do when multiple scenes/levels added
}
