using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneCount3 : MonoBehaviour
{
    public static int count;
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
	countText.text = "Destroy All The Enemy Planes " + count.ToString() + "/6";
    }

    // Update is called once per frame
    void Update()
    {
	countText.text = "Destroy All The Enemy Planes " + count.ToString() + "/6";
        if(count == 6)
	{
	    countText.color = Color.green;
	}
    }
}
