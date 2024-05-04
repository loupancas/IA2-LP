using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAbilities : MonoBehaviour
{
    public bool isCollected = false;
    public int value = 1;
    //public GameObject objectPowerUp;

    [SerializeField] private PlayerController pc;
    [SerializeField] private int fadeTime;
   

    private static PowerUpAbilities instance;

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

    public void speedPowerUp(int ammount)
    {
        NormalizeStats();
        Debug.Log("Powered up");
        pc.Speed *= ammount;
        StartCoroutine(PowerFade());
    }
    public void jumpPowerUp(float ammount)
    {
        NormalizeStats();
        Debug.Log("Powered up");
        pc.jump *= ammount;
        StartCoroutine(PowerFade());
    }
    public void inmortalPowerUp()
    {
        NormalizeStats();
        Debug.Log("Powered up");
        StartCoroutine(PowerFade());
    }
    public IEnumerator PowerFade()
    {
        yield return new WaitForSeconds(fadeTime);

        NormalizeStats();
    }
    public void NormalizeStats()
    {
       
        pc.Speed = pc.defaultSpeed;
        pc.jump = pc.defaultJump;
        //HealthSystem.Get().inmortal = false;
    }

    public static PowerUpAbilities Get()
    {
        return instance;
    }


}
