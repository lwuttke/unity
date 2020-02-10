using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timer;
    float gameTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*gameTimer += Time.deltaTime;
        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;
        int hours = (int)(gameTimer / 3600) % 24;
        string timerString = string.Format("{0:0}:{0:00}:{0:00}",hours, minutes, seconds);*/
        float currentTime = gameTimer + Time.time;

        timer.text = currentTime.ToString("0.00");
        
    }
}
