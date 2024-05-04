using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static partial class TheBest
    {
        // for scores: higher is better
        private static string s_HighScore = "HighScore";

        public static bool HaveBestScore
        {
            get
            {
                return PlayerPrefs.HasKey(s_HighScore);
            }
        }

        public static float BestScore
        {
            get
            {
                return PlayerPrefs.GetFloat(s_HighScore, 0);
            }
            private set     // make this public if you trust yourself
            {
                PlayerPrefs.SetFloat(s_HighScore, value);
            }
        }

        public static bool RecordScoreIfHigher(int score)
        {
            if (!HaveBestScore || (score > BestScore))
            {
                BestScore = score;
                return true;
            }
            return false;
        }

        public static void ClearBestScore()
        {
            if (HaveBestScore)
            {
                PlayerPrefs.DeleteKey(s_HighScore);
            }
        }
    }

    //int bestScore = TheBest.BestScore;
}
