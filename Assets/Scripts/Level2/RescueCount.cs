using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RescueCount : MonoBehaviour
{
    public static int count;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
	countText.text = "Rescue all the men " + count.ToString() + "/7";
    }

    // Update is called once per frame
    void Update()
    {
	countText.text = "Rescue all the men " + count.ToString() + "/7";
        if(count == 7)
	{
	    countText.color = Color.green;
	}
		
    }
}
