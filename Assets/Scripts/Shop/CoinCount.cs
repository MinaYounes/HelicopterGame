using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
	
    public static int coins;
    public Text coinText;
    public Text notEnoughCoins;
    public Text noCoins;
 
    // Start is called before the first frame update
    void Start()
    {
	    coinText.text = coins.ToString();
        //notEnoughCoins = GameObject.Find("NotEnough").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    // adds coin to players wallet
    public void AddCoins(int coinsToAdd)
    {
        coins += coinsToAdd;
	    coinText.text = coins.ToString();
    }

    // if player has enough coins, upgrade what they wanted.
    // if player doesn't have enough coins, display error message
    public void SubtractCoins(int coinsToSubtract, string component)
    {
        // when player doesn't have enough coins
        if(coins - coinsToSubtract < 0)
	    {
            notEnoughCoins = GameObject.Find("NotEnough").GetComponent<Text>();
            notEnoughCoins.text = "Not Enough Coins!";
            
            StartCoroutine(StartCount());
        }
        // player has enough coins
	    else
        {
	        coins -= coinsToSubtract;
	        coinText.text = coins.ToString();

            if(component == "1d")
            {
                Bullet.IncreaseDamage();
            }
            else if(component == "1s")
            {
                Bullet.IncreaseSpeed();
            }
            else if (component == "2d")
            {
                Bullet2.IncreaseDamage();
            }
            else if (component == "2s")
            {
                Bullet2.IncreaseSpeed();
            }
            else if (component == "3d")
            {
                Bullet3.IncreaseDamage();
            }
            else if (component == "3s")
            {
                Bullet3.IncreaseSpeed();
            }
        }
    }

    // displays "Not Enough Coins" message for 1 second
    IEnumerator StartCount()
    {
        yield return new WaitForSeconds(1f);
       
        notEnoughCoins = GameObject.Find("NotEnough").GetComponent<Text>();
        notEnoughCoins.text = "";
 
    }
}
