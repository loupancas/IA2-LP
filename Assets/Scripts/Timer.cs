using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;
    public static Text timer_T;

    void Start()
    {
        timer_T = GetComponent<Text>();
    }


    void Update()
    {
        time += 1 * Time.deltaTime;

        string seconds = (time % 60).ToString("00");
        string minutes = Mathf.Floor((time % 3600) / 60).ToString("00");

        timer_T.text = "Time:" + " " + minutes + ":" + seconds;
    }
}
