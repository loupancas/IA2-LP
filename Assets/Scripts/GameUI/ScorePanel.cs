using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScorePanel : MonoBehaviour
{
    public Text scoreText; // Asigna un Text UI en el Inspector donde se mostrarán los resultados
    public Button closeButton; // Asigna un Button UI en el Inspector para cerrar el panel

    private void Start()
    {
        closeButton.onClick.AddListener(ClosePanel);
    }

    public void ShowScores(string[] scores)
    {
        scoreText.text = string.Join("\n", scores);
        gameObject.SetActive(true); // Activa el panel para mostrar los resultados
    }

    private void ClosePanel()
    {
        gameObject.SetActive(false); // Desactiva el panel al cerrarlo
    }
}
