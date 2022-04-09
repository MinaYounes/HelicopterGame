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
    private void Update()
    {
        // keep buttons disabled of upgrades if they were bought 
        if (Bullet.speed == 7f)
        {
            DisableButton("missileSpeedButton");
        }
        if(Bullet.damage == 30)
        {
            DisableButton("missileDamageButton");
        }
        if (Bullet2.speed == 5f)
        {
            DisableButton("subsonicSpeedButton");
        }
        if (Bullet2.damage == 40)
        {
            DisableButton("subsonicDamageButton");
        }
        if (Bullet3.speed == 9f)
        {
            DisableButton("mach8SpeedButton");
        }
        if (Bullet3.damage == 20)
        {
            DisableButton("mach8DamageButton");
        }
    }

    // if back button clicked
    public void GoBack()
    {
        coins = CoinCount.coins;
	    SceneManager.LoadScene("LevelSuccess");
    }
    // if upgrade of missile speed clicked
    public void MissileSpeed()
    {
        // checks if could upgrade speed of bullet1
        CheckCoins("1s");
    }
    // if upgrade of missile damage clicked
    public void MissileDamage()
    {
        // checks if could upgrade damage of bullet2
        CheckCoins("1d");
    }
    // if upgrade of subsonic speed clicked
    public void SubsonicSpeed()
    {
        // checks if could upgrade speed of bullet2
        CheckCoins("2s");
    }
    // if upgrade of subsonic damage clicked
    public void SubsonicDamage()
    {
        // checks if could upgrade damage of bullet3
        CheckCoins("2d");
    }
    // if upgrade of mach8 speed clicked
    public void Mach8Speed()
    {
        // checks if could upgrade speed of bullet3
        CheckCoins("3s");        
    }
    // if upgrade of mach8 damage clicked
    public void Mach8Damage()
    {
        // checks if could upgrade damage of bullet3
        CheckCoins("3d");
    }

    // checks if could upgrade or not
    private void CheckCoins(string component)
    {
        upgradeCost = 30;
        cam.GetComponent<CoinCount>().SubtractCoins(upgradeCost, component);
  
    }

    // makes button unclickable
    private void DisableButton(string name)
    {
        myButton = GameObject.Find(name).GetComponent<Button>();
        myButton.interactable = false;
    }
}
