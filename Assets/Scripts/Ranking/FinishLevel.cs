using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    TheBestScore theBestScore;
    TheBestTime BestTime;
    [SerializeField] private Timer timer;
    public ScoreManager scoreManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            float completionTime = timer.getElapsedTime();
            timer.resetTimer();
            GameManager.instance.saveCompletionCandies();
            GameManager.instance.saveCompletionTime(completionTime);
            ScoreManager.instance.AddPlayerScore(PlayerManager.instance.GetPlayerName(),completionTime,GameManager.instance.candies);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameManager.instance.ResetCandies();

        }
    }
}
