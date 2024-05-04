using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
    public class TheBestScore : MonoBehaviour
    {
        
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
            private set     
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

    //int bestScore = TheBestScore.BestScore;

