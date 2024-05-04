using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RankManager : MonoBehaviour
{
    public TextMeshProUGUI theBestScore;
    public TextMeshProUGUI theBestTime;

    void Start()
    {
    }

    public void HighestScore()
    {
        float BestScore = TheBestScore.BestScore;
        theBestScore.text = BestScore.ToString();
    }

    public void HighestTime()
    {
        float BestTime = TheBestTime.BestTime;
        theBestTime.text = BestTime.ToString();
    }
}
