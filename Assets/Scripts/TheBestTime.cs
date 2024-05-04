using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class TheBestTime : MonoBehaviour
{
        private static string s_LowestTime = "LowestTime";

        public static bool HaveBestTime
        {
            get
            {
                return PlayerPrefs.HasKey(s_LowestTime);
            }
        }

        public static float BestTime
        {
            get
            {
                return PlayerPrefs.GetFloat(s_LowestTime, 0);
            }
            private set    
            {
                PlayerPrefs.SetFloat(s_LowestTime, value);
            }
        }

        public static bool RecordTimeIfLower(float time)
        {
            if (!HaveBestTime || (time < BestTime))
            {
                BestTime = time;
                return true;
            }
            return false;
        }

        public static void ClearBestTime()
        {
            if (HaveBestTime)
            {
                PlayerPrefs.DeleteKey(s_LowestTime);
            }
        }
    }
    //float bestTime = TheBest.BestTime;

