using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //public IEnumerator DoChangeToScene(string sceneName)
    //{
      //  yield return new WaitForSeconds(10);
       // SceneManager.LoadScene(sceneName);
   // }
}
