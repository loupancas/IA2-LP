using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard: MonoBehaviour
{
    private List<(string, int)> scores = new List<(string, int)>();

    // Método para agregar un nuevo puntaje al ranking
    public void AddScore(string playerName, int score)
    {
        scores.Add((playerName, score));
    }

    // Método para mostrar el ranking de puntajes
    public void ShowRanking()
    {
        // Ordena los puntajes de mayor a menor
        scores.Sort((x, y) => y.Item2.CompareTo(x.Item2));

        // Muestra el ranking
        Console.WriteLine("Ranking:");
        for (int i = 0; i < scores.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scores[i].Item1}: {scores[i].Item2}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Scoreboard scoreboard = new Scoreboard();

        // Agrega algunos puntajes de ejemplo
        scoreboard.AddScore("Player1", 100);
        scoreboard.AddScore("Player2", 150);
        scoreboard.AddScore("Player3", 120);
        scoreboard.AddScore("Player4", 80);

        // Muestra el ranking
        scoreboard.ShowRanking();
    }
}
