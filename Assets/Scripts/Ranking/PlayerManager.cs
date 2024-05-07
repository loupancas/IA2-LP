using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{

    public TMP_InputField nameInputField;
    private string playerName;
    public static PlayerManager instance;

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
    public void SavePlayerData ()
    {
        string playerName = nameInputField.text;
        if(string.IsNullOrEmpty(playerName))
        {
            playerName = "Unknow";
        }
    }

    public string GetPlayerName()
    {
        return playerName;
    }

}
