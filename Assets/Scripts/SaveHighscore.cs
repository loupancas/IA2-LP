using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveHighscore : MonoBehaviour
{
    public Text highscoreT;
    private Text highScoreText;
    void Start()
    {
        highscoreT = GetComponent<Text>();
        highscoreT.text = PlayerPrefs.GetFloat("Highscore", 0).ToString();

    }
    void ShowHighscore()
    {
        float highscore = PlayerPrefs.GetFloat("HighScore");
        highScoreText.text = highscore.ToString();
    }
    public static void UpdateScore()
    {
        if (Timer.time < PlayerPrefs.GetFloat("Highscore", Timer.time))
        {
            PlayerPrefs.SetFloat("Highscore", Timer.time);
        }
    }
}
