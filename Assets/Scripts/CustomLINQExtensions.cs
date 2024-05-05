using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomLINQExtensions
{
    // Extensión para convertir GameObjects en sus componentes especificados
    public static IEnumerable<T> ConvertTo<T>(this IEnumerable<GameObject> source) where T : Component
    {
        List<T> result = new List<T>();
        foreach (GameObject gameObject in source)
        {
            T component = gameObject.GetComponent<T>();
            if (component != null)
            {
                result.Add(component);
            }
        }
        return result;
    }
}
