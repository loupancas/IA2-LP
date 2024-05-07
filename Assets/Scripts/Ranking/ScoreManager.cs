using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    public List<PlayerData> playerScores = new List<PlayerData>();
    public static ScoreManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPlayerScore(string name, float time, int candies)
    {
        playerScores.Add(new PlayerData( name, time, candies));
    }



}
