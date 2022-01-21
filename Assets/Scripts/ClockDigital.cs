using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ClockDigital : MonoBehaviour
{
    float secondsTextNew = 60f, minutesTextNew = 60f, hoursTextNew = 12f;

    public Text hoursText, minutesText, secondText;


    void Update()
    {
        DateTime time = DateTime.Now;
                
        hoursText.text = "" + (time.Hour * (12f / hoursTextNew)) + " :";
        minutesText.text = "" + (time.Minute * (60f / minutesTextNew)) + " :";
        secondText.text = "" + (time.Second * (60f / secondsTextNew));
    }
}
