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
        Debug.Log("missileSpeed: " + Bullet.speed);
        Debug.Log("missileDmage: " + Bullet.damage);

        Debug.Log("2spped: " + Bullet2.speed);
        Debug.Log("2speed: " + Bullet2.damage);

        Debug.Log("3speed: " + Bullet3.speed);
        Debug.Log("3speed: " + Bullet3.damage);

        // keep buttons disabled if they were bought 
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

    public void MissileSpeed()
    {
        // checks if could upgrade speed of bullet1
        CheckCoins("1s");
    }

    public void MissileDamage()
    {
        // checks if could upgrade damage of bullet2
        CheckCoins("1d");
    }

    public void SubsonicSpeed()
    {
        // checks if could upgrade speed of bullet2
        CheckCoins("2s");
    }

    public void SubsonicDamage()
    {
        // checks if could upgrade damage of bullet3
        CheckCoins("2d");
    }

    public void Mach8Speed()
    {
        // checks if could upgrade speed of bullet3
        CheckCoins("3s");        
    }

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
