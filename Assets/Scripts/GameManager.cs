using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float candies;
    public TextMeshProUGUI candyText;
    private static GameManager instance;

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
    public void AddCandy(int ammount)
    {
        candies += ammount;
        candyText.text = ": " + candies;
    }

    public void MenuBackButton() 
    {
        Destroy(PlayerController.Get().gameObject);
        SceneManager.LoadScene("ChoosePlayer");
    }

    public static GameManager Get()
    {
        return instance;
    }
}
