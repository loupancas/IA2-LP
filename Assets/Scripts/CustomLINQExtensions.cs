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

    public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, System.Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (T item in source)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }

   
}
