using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomPlayerDataExtensions
{
    //IA filtra los jugadores que han completado el juego en menos tiempo que cierto umbral definido
    public static IEnumerable<PlayerData> FilterByCompletionTimeThreshold(this IEnumerable<PlayerData> playerData, float threshold)
    {
        foreach (var data in playerData)
        {
            if (data.completionTime < threshold)
            {
                yield return data;
            }
        }
    }
    //IA Incrementa el número de caramelos recolectados por cada jugador en una cantidad dada
    public static IEnumerable<PlayerData> IncrementCandiesCollected(this IEnumerable<PlayerData> playerData, int increment)
    {
        
        foreach (var data in playerData)
        {
            var modifiedData = new PlayerData(data.playerName, data.completionTime, data.candiesCollected + increment);
            yield return modifiedData;
        }
    }


}
