using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    // List to store scores and levels
    public List<int> scores = new List<int>();
    public List<int> tries = new List<int>();
    public List<float> time = new List<float>();
    private List<int> candies = new List<int>();
    private List<string> playerName = new List<string>();

    // Method to add a new score and level
    public void AddScore(int score, int tries, float time, int candies, string playerName)
    {
        scores.Add(score);
        this.tries.Add(tries);
        this.time.Add(time);
        this.candies.Add(candies);
        this.playerName.Add(playerName);

    }

    // Method to calculate and return the maximum score
    public int GetMaxScore()
    {
        // Zip the scores and levels together
        var zippedData = tries.Zip(tries, (score, time) => new { Score = score, Time = time });

        // Concatenate the zipped data with a default score and level
        var concatenatedData = zippedData.Concat(new[] { new { Score = 0, Time = 0 } });

        // Use SelectMany to flatten the concatenated data into a single sequence
        var flattenedData = concatenatedData.SelectMany(x => new[] { x.Score });

        // Calculate the maximum score
        return  flattenedData.Max();
    }

    private void Start()
    {
        Debug.Log("Max Score: " + GetMaxScore());
    }
}
