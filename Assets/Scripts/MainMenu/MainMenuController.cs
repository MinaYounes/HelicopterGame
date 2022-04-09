using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

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
        LevelSuccessController.SceneTracker = 1;
        DeathController.SceneTracker = 1;

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

    // if load game wanted, gets previously saved data from saved file 
    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        CoinCount.coins = data.coins;
        LevelSuccessController.SceneTracker = data.sceneTracker;
        DeathController.SceneTracker = ++data.deadSceneTracker;
        
        EnemyPlane.level = ++data.level;

        ReadInput.emailEntered = data.email;

        Bullet.damage = data.bullet1Damage;
        Bullet.speed = data.bullet1Speed;

        Bullet2.damage = data.bullet2Damage;
        Bullet2.speed = data.bullet2Speed;

        Bullet3.damage = data.bullet3Damage;
        Bullet3.speed = data.bullet3Speed;

        LevelSuccessController.SceneTracker++;
        SceneManager.LoadScene(LevelSuccessController.SceneTracker);
    }

    // loads how to play scene
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
