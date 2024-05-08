using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public string playerName;
    public float completionTime;
    public int candiesCollected;

    public PlayerData(string name, float time, int collected)
    {
        playerName = name;
        completionTime = time;
        candiesCollected = collected;
    }

   
}

[System.Serializable]
public class PlayerDataTime
{
    public string playerName;
    public float completionTime;

    public PlayerDataTime(string name, float time)
    {
        playerName = name;
        completionTime = time;
    }


}

[System.Serializable]
public class PlayerDataCandies
{
    public string playerName;
    public int candiesCollected;

    public PlayerDataCandies(string name, int collected)
    {
        playerName = name;
        candiesCollected = collected;
    }


}