using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Group : MonoBehaviour
{
    public PlayerData playerData;
    public Text playerScoretext;
    public Text playerGameOverText;

    private void Start()
    {
        UpdateGroup();
    }

    private void UpdateGroup()
    {
        //playerImage.sprite = playerData.playerImage;
        //playerScoretext.text = playerData.playerScore.ToString();
        //playerGameOverText.text = playerData.playerGameOverText;
    }
}
