using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    private string input;
    public static bool emailEntered = false;
 
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // take user email input
    public void ReadString(string text)
    {
        input = text;
        emailEntered = true;
        Debug.Log("email: " + input);
    }
}
