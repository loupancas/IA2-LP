using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{

    public TMP_InputField nameInputField;
    private string playerName;
    public static PlayerManager instance;
    [SerializeField] private Timer timer;


    private void Awake()
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
    public void SavePlayerName ()
    {
        playerName = nameInputField.text;
        if(string.IsNullOrEmpty(playerName))
        {
            playerName = "Unknow";
        }
    }

    public string GetPlayerName()
    {
        return playerName;
    }

    public void OpenPanel()
    {
        nameInputField.transform.parent.gameObject.SetActive(true);
    }

    public void ClosePanel()
    {
        nameInputField.transform.parent.gameObject.SetActive(false);
        nameInputField.text = "";
        timer.resetTimer();
    }

   

}
