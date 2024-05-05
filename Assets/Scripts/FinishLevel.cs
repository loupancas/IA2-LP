using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    TheBestScore theBestScore;
    TheBestTime BestTime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            //string text = Timer.timer_TMP.text;
            //BestTime = new TheBestTime(text);
            // Finish the game by loading the next scene or displaying a game completion screen
            // For demonstration, let's just reload the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
