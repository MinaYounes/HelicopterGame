using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

 /* REUSED CODE from Youtuber "AIA */
 
public class Timer : MonoBehaviour
{
    // 1:15 minutes
    private float timeDuration = 1.25f * 60f;

    private float timer;
    [SerializeField]
    private TextMeshProUGUI firstMinute;
    [SerializeField]
    private TextMeshProUGUI secondMinute;
    [SerializeField]
    private TextMeshProUGUI seperator;
    [SerializeField]
    private TextMeshProUGUI firstSecond;
    [SerializeField]
    private TextMeshProUGUI secondSecond;

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        // count down if time is bigger than 0
        if (timer > 0)
        {
            // subtract time elapsed from frame
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
        // once timer reaches 0, player failed
        else
        {
            timer = 0;
            SceneManager.LoadScene("Death");
        }
    }

    private void ResetTimer()
    {
        timer = timeDuration;
    }

    private void UpdateTimerDisplay(float time)
    {
        // minutes
        float minutes = Mathf.FloorToInt(time / 60);
        // seconds
        float seconds = Mathf.FloorToInt(time % 60);

        // string time formatting 
        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        firstMinute.text = currentTime[0].ToString();
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();
    }


}
