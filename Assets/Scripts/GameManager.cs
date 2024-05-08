using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int candies;
    public TextMeshProUGUI candyText;
    public static GameManager instance;
    public List<float> levelCompletionTimes = new List<float>();
    public List<int> levelCompletionCandies = new List<int>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void saveCompletionTime(float time)
    {
        levelCompletionTimes.Add(time);
    }
    public void AddCandy(int ammount)
    {
        candies += ammount;
        candyText.text = ": " + candies;
    }

    public void ResetCandies()
    {
        candies = 0;
        candyText.text = ": " + candies;
    }
    public void saveCompletionCandies()
    {
        levelCompletionCandies.Add(candies);
    }

    public void MenuBackButton() 
    {
        Destroy(PlayerController.Get().gameObject);
    }

    //public static GameManager Get()
    //{
    //    return instance;
    //}
}
