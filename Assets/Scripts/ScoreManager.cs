using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    // List to store scores and levels
    private List<int> scores = new List<int>();
    private List<int> levels = new List<int>();

    // Method to add a new score and level
    public void AddScore(int score, int level)
    {
        scores.Add(score);
        levels.Add(level);
    }

    // Method to calculate and return the maximum score
    public int GetMaxScore()
    {
        // Zip the scores and levels together
        var zippedData = scores.Zip(levels, (score, level) => new { Score = score, Level = level });

        // Concatenate the zipped data with a default score and level
        var concatenatedData = zippedData.Concat(new[] { new { Score = 0, Level = 0 } });

        // Use SelectMany to flatten the concatenated data into a single sequence
        var flattenedData = concatenatedData.SelectMany(x => new[] { x.Score });

        // Calculate the maximum score
        return flattenedData.Max();
    }
}
