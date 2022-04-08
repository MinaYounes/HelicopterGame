using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    private string input;
    public static bool emailEntered = false;
  
    // take user email input
    public void ReadString(string text)
    {
        input = text;
        emailEntered = true;   
    }
}
