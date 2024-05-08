using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public List<PlayerData> playerScores = new List<PlayerData>();
    public List<PlayerData> fastPlayerList = new List<PlayerData>();
    public List<PlayerData> candyAumentedList = new List<PlayerData>();
    public static ScoreManager instance;
    public GameObject panel;
    public GameObject panelDetailedScores;
    public GameObject panelNamesTimes;
    public GameObject panelAllScores;
    public GameObject panelSummary;

    TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreTextDetailed;
    public TextMeshProUGUI scoreTextNamesTimes;
    public TextMeshProUGUI scoreTextAllScores;
    public TextMeshProUGUI scoreTextSummary;


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
    //IA2-LINQ
    public void ShowFastestPlayers()
    {

        fastPlayerList = playerScores.FilterByCompletionTimeThreshold(10).ToList();
    }
    //IA2-LINQ
    public void IncrementCandies()
    {
        candyAumentedList = playerScores.IncrementCandiesCollected(5).ToList();
    }
    //IA2-LINQ
    public void DisplayNamesTimes()
    {
       var namesWithTimes = playerScores.Select(p => p.playerName).Zip( playerScores.Select(p=>p.completionTime),(name,time)=>$" { name }:{ time } ");
        foreach (var nameTime in namesWithTimes)
        {
            Debug.Log(nameTime);
        }

        OpenPanel(namesWithTimes.ToArray(), panelNamesTimes, scoreTextNamesTimes);
    }
    //IA2-LINQ
    public void DisplayAllScores()
    {
        var allScores = GetTopTimes().Concat(GetTopCandies()).ToList();
        foreach (var score in allScores)
        {
            Debug.Log(score.playerName + " " + score.completionTime + " " + score.candiesCollected);
        }
        OpenPanel(allScores.Select(p => $"{p.playerName} - Time: {p.completionTime}, Candies: {p.candiesCollected}").ToArray(), panelAllScores, scoreTextAllScores);
    }
    //IA2-LINQ
    public void DisplayDetailedScores()
    {
        var detailedScores = playerScores.SelectMany( p => new List <string> { $"{p.playerName} - Time: {p.completionTime}", $"{p.playerName} - Candies: {p.candiesCollected}" });
        foreach (var score in detailedScores)
        {
            Debug.Log(score);
        }
        OpenPanel(detailedScores.ToArray(), panelDetailedScores , scoreTextDetailed);
    }
    //IA2-LINQ
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

        //OpenPanel(playerSummary.First() , panelSummary, scoreTextSummary);
    }

  
    public void OpenPanel(string[] text, GameObject panel, TextMeshProUGUI textComponent)
    {
        if (panel != null && textComponent != null)
        {
            bool isActive = panel.activeSelf; // Verifica si el panel está activo
            panel.SetActive(!isActive); // Activa o desactiva el panel
            scoreText.text = string.Join(", ", text);

        }

    }

}
