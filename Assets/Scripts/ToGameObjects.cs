using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ToGameObjects : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;

    void Start()
    {
        // Supongamos que tienes una lista de GameObjects llamada 'gameObjects'
        List<GameObject> gameObjects = new List<GameObject>();
        gameObjects.Add(gameObject1);
        gameObjects.Add(gameObject2);
        gameObjects.Add(gameObject3);

        // Ahora puedes usar LINQ para filtrar y convertir los GameObjects a componentes específicos
        List<Rigidbody> rigidbodies = gameObjects
            .Where(go => go.GetComponent<Rigidbody>() != null) // Filtras los GameObjects que tienen Rigidbody
            .ConvertTo<Rigidbody>() // Conviertes los GameObjects en Rigidbody
            .ToList(); // Conviertes el resultado en una lista de Rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
