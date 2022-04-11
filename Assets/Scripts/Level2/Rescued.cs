using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rescued : MonoBehaviour
{
    public static bool rescue;
    public Text rescueText;

    // Start is called before the first frame update
    void Start()
    {
        rescue = false;
	rescueText.text = "deliver the men to the top of the building";
    }

    // Update is called once per frame
    void Update()
    {
        if(rescue == true)
	{
	    rescueText.color = Color.green;
	}
		
    }
}
