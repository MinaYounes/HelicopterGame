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
    }

    public void MissileDamage()
    {
        CheckCoins();
        Bullet.IncreaseDamage();
    }

    public void SubsonicSpeed()
    {
        CheckCoins();
        Bullet2.IncreaseDamage();
    }

    public void SubsonicDamage()
    {
        CheckCoins();
        Bullet2.IncreaseDamage();
    }

    public void Mach8Speed()
    {
        CheckCoins();
        Bullet3.IncreaseDamage();
    }

    public void Mach8Damage()
    {
        CheckCoins();
        Bullet3.IncreaseDamage();
    }

    private void CheckCoins()
    {
        upgradeCost = 30;
        if(cam.GetComponent<CoinCount>().SubtractCoins(upgradeCost) != 1)
        {
            return;
        }
    }
}
