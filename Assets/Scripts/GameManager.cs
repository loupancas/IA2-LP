using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _timerText;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    
    public static float DeltaTime => Time.deltaTime;
    private float Timer { get; set; }

    public static GameManager Instance { get; private set; }

   
    public void Update()
    {
        if (GameManager.Instance!=null) Timer += Timer*DeltaTime; 

        _timerText.text = $"Time: {Timer}";
    }



}


