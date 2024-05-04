using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankManager : MonoBehaviour
{
    public List<PlayerData> PlayerDataList= new List<PlayerData>();
    // Start is called before the first frame update
    void Start()
    {
        HighestScore();
    }

    private void HighestScore()
    {
        int highestScore = 0;
        PlayerData highestScorePlayer = null;
        for (int i=0; i<PlayerDataList.Count;i++)
        {
            //if (playerData[i].playerHighestScore > highestScore)
            {
                //highestScore = playerData[i].playerHighestScore;
            }
        }
    }

    private int SortByScore(PlayerData a, PlayerData b)
    {
        return 0;
        //return a.playerHighestScore.CompareTo(b.playerHighestScore);
    }
    
    private void UpdateRank()
    {
       for(int i = 0; i < PlayerDataList.Count; i++)
        {
            //groups[i].playerData = PlayerDataList[i];
            //groups[i].UpdateGroup();
        }

    }

}
