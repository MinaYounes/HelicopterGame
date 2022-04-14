using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitObj : MonoBehaviour
{
    public static bool exited;
    public Text exitText;
    // Start is called before the first frame update
    void Start()
    {
        exited = false;
	exitText.text = "avoid obstacles and reach the \n" +
            "exit before time runs out";
    }

    // Update is called once per frame
    void Update()
    {
        if(exited == true)
	{
	    exitText.color = Color.green;
	}
    }
}
