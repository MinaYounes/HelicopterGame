using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirportCount : MonoBehaviour
{
    public GameObject cam;
    public static int count;
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
	countText.text = "Destroy Both Airports " + count.ToString() + "/2";  
    }

    // Update is called once per frame
    void Update()
    {
	countText.text = "Destroy Both Airports " + count.ToString() + "/2";
        if(count == 2)
	{
	    countText.color = Color.green;
	}  
    }
}
