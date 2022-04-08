using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
	
    public static int coins;
    public Text coinText;
 
    // Start is called before the first frame update
    void Start()
    {
	    coinText.text = coins.ToString();
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
	        Debug.Log("Not Enough Money");
	    }
	    else
        {
	        coins -= coinsToSubtract;
	        coinText.text = coins.ToString();
	    }
    }
}
