using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    public static int coins;
    int upgradeCost;
    public GameObject cam;
    static private Button myButton;

    
    void Start()
    {
	    CoinCount.coins = coins;        
    }

    // if back button clicked
    public void GoBack()
    {
	    SceneManager.LoadScene("LevelSuccess");
    }

    public void MissileSpeed()
    {
        CheckCoins();

        Bullet.IncreaseSpeed();
        //DisableButton("missileSpeedButton");
        

        
    }

    public void MissileDamage()
    {
        CheckCoins();

        Bullet.IncreaseDamage();
       // DisableButton("missileDamageButton");
        
    }

    public void SubsonicSpeed()
    {
        CheckCoins();

        Bullet2.IncreaseDamage();
        //DisableButton("subsonicSpeedButton");
    }

    public void SubsonicDamage()
    {
        CheckCoins();
 
        Bullet2.IncreaseDamage();
       // DisableButton("subsonicDamageButton");
    }

    public void Mach8Speed()
    {
        CheckCoins();
        
        Bullet3.IncreaseDamage();
       // DisableButton("mach8SpeedButton");
        
    }

    public void Mach8Damage()
    {
        CheckCoins();

        Bullet3.IncreaseDamage();
        //DisableButton("mach8DamageButton");

    }

    private void CheckCoins()
    {
        upgradeCost = 30;
        cam.GetComponent<CoinCount>().SubtractCoins(upgradeCost);
    }

    // makes button unclickable
    private void DisableButton(string name)
    {
        myButton = GameObject.Find(name).GetComponent<Button>();
        myButton.interactable = false;
    }
}
