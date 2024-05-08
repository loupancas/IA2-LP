using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.5f;
    public RectTransform menuContainer;
    public GameObject confirmationPanel;
    public GameObject tutorialPanel;
    public GameObject buttonTutorial;

    public Button[] levelsButtons;
    public TextMeshProUGUI textInstrucions;
    public List<String> instructionList =new List<String>();
    public bool isFadeOut;
    private int selectedIndex;

    public GameObject fpCanva;
    public GameObject icCanva;
    public GameObject namestimescanva;
    public GameObject detailedcanva;
    public GameObject allScorecanva;


    IEnumerator Start()
    {   
        confirmationPanel.SetActive(false);
        tutorialPanel.SetActive(false);

        return null;

    }

    private void Update()
    {
       
            if (isFadeOut)
            {
                fadeGroup.alpha -= Time.deltaTime * fadeInSpeed;
            }    
            
    }         


    private void SceneLevel(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    } 


    public void Tutorial()
    {
        tutorialPanel.SetActive(true);
    }
    public void CloseTutorial()
    {
        tutorialPanel.SetActive(false);

    }

    public void FastPlayerCanva()
    {
        fpCanva.SetActive(true);
    }
    public void CloseFastPlayerCanva()
    {
        fpCanva.SetActive(false);
    }

    public void IncrementCandiesCanva()
    {
        icCanva.SetActive(true);
    }
    public void CloseIncrementCandiesCanva()
    {
        icCanva.SetActive(false);
    }

    public void NamesTimesCanva()
    {
        namestimescanva.SetActive(true);
    }
    public void CloseNamesTimesCanva()
    {
        namestimescanva.SetActive(false);
    }

    public void DetailedCanva()
    {
        detailedcanva.SetActive(true);
    }
    public void CloseDetailedCanva()
    {
        detailedcanva.SetActive(false);
    }



}
