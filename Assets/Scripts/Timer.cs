using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private float time = 0f;
    public TextMeshProUGUI timer_TMP;
    void Start()
    {
        timer_TMP = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        time += 1 * Time.deltaTime;

        string seconds = (time % 60).ToString("00");
        string minutes = Mathf.Floor((time % 3600) / 60).ToString("00");

        timer_TMP.text = "Time:" + " " + minutes + ":" + seconds;
       
    }
}
