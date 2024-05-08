using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    public List<PlayerData> playerScores = new List<PlayerData>();
    public List<PlayerData> fastPlayerList = new List<PlayerData>();
    public List<PlayerData> candyAumentedList = new List<PlayerData>();
    public static ScoreManager instance;
    public ScorePanel scorePanel;

    MenuScene MenuScene;
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
        PlayerData newPlayerData = new PlayerData(name, time, candies);
        playerScores.Add(newPlayerData);
        
    }

    public IEnumerable<PlayerData> GetTopTimes()
    {
        return playerScores.OrderBy(p => p.completionTime);
    }

    public IEnumerable<PlayerData> GetTopCandies()
    {
        return playerScores.OrderBy(p => p.candiesCollected);
    }

    public void ShowFastestPlayers()
    {

        fastPlayerList = playerScores.FilterByCompletionTimeThreshold(10).ToList();
    }

    public void IncrementCandies()
    {
        candyAumentedList = playerScores.IncrementCandiesCollected(5).ToList();
    }

    public void DisplayNamesTimes()
    {
       //var namesWithTimes = playerScores.Select(p => p.playerName + " " + p.completionTime).ToList();
       var namesWithTimes = playerScores.Select(p => p.playerName).Zip( playerScores.Select(p=>p.completionTime),(name,time)=>$" { name }:{ time } ");
        foreach (var nameTime in namesWithTimes)
        {
            Debug.Log(nameTime);
        }

    }

    public void DisplayAllScores()
    {
        var allScores = GetTopTimes().Concat(GetTopCandies()).ToList();
        foreach (var score in allScores)
        {
            Debug.Log(score.playerName + " " + score.completionTime + " " + score.candiesCollected);
        }
    }

    public void DisplayDetailedScores()
    {
        var detailedScores = playerScores.SelectMany( p => new List <string> { $"{p.playerName} - Time: {p.completionTime}", $"{p.playerName} - Candies: {p.candiesCollected}" });
        foreach (var score in detailedScores)
        {
            Debug.Log(score);
        }
    }
    //crea anonimo que incluye el nombre del jugador y una tupla con el tiempo y la cantidad de dulces.
    public IEnumerable<object> GetPlayerSummary()
    {
        var summary = playerScores.Select(p => new { p.playerName, taC = (Time: p.completionTime, Candies: p.candiesCollected) });
        return summary.ToList();
    }

    public void GetSummary()
    {
        var playerSummary = GetPlayerSummary();
        foreach (var summary in playerSummary)
        {
            Debug.Log(summary);
        }

    }

    public void DisplayAllScoresInPanel()
    {
        var allScores = GetTopTimes().Concat(GetTopCandies()).Select(score => $"{score.playerName} - Time: {score.completionTime}, Candies: {score.candiesCollected}").ToArray();
        scorePanel.ShowScores(allScores);
    }

}
