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

    public void AddCoins(int coinsToAdd)
    {
        coins += coinsToAdd;
	    coinText.text = coins.ToString();
    }

    public void SubtractCoins(int coinsToSubtract)
    {
        if(coins - coinsToSubtract < 0)
	    {
            notEnoughCoins = GameObject.Find("NotEnough").GetComponent<Text>();
            notEnoughCoins.text = "Not Enough Coins!";
            StartCoroutine(StartCount());
            

        }
	    else
        {
	        coins -= coinsToSubtract;
	        coinText.text = coins.ToString();
	    }
    }

    IEnumerator StartCount()
    {
        yield return new WaitForSeconds(1f);
       
        notEnoughCoins = GameObject.Find("NotEnough").GetComponent<Text>();
        notEnoughCoins.text = "";
    }
}
