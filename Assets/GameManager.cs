using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public TMP_Text timerText1;
    public TMP_Text timerText2;
    
    private const float SECONDS_OF_A_ROUND = 10;
    private float secondsLeft = 0;

    // Start is called before the first frame update
    void Start()
    {
        secondsLeft = SECONDS_OF_A_ROUND;
    }

    // Update is called once per frame
    void Update()
    {
        secondsLeft -= Time.deltaTime;
        TimeSpan timeSpan = TimeSpan.FromSeconds(secondsLeft);
        string timeText = string.Format("{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        timerText1.text = timeText;
        timerText2.text = timeText;
    }
}
