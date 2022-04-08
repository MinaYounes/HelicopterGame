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

    public void goBack()
    {
	SceneManager.LoadScene("LevelSuccess");
    }

    public void weaponOne()
    {
        upgradeCost = 20;

	cam.GetComponent<CoinCount>().SubtractCoins(upgradeCost);
	//upgrade ship

    }

    public void weaponTwo()
    {
	upgradeCost = 30;
	
	cam.GetComponent<CoinCount>().SubtractCoins(upgradeCost);
	//upgrade ship

    }

    public void weaponThree()
    {
	upgradeCost = 30;

	cam.GetComponent<CoinCount>().SubtractCoins(upgradeCost);
	//upgrade ship
    }
}
