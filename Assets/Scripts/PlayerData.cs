using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
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
