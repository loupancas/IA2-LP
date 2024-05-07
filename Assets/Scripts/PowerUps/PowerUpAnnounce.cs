using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class PowerUpAnnounce : MonoBehaviour
{
    public Transform powerUpParent;
    public List<GameObject> powerUps = new List<GameObject>();
    public List<GameObject> collectedPowerUp = new List<GameObject>();
    public List<GameObject> candyList = new List<GameObject>();
    public List<GameObject> powerList = new List<GameObject>();
    public TextMeshProUGUI notificationText;
    public float interactionRange = 1f;
    public GameObject player;

    void Start()
    {
        PopulatePowerUpsList();
        ListSpecificTypes();
    }

    private void Update()
    {
        if (player != null)
        {
            StartCoroutine(InteractWithClosestPowerUpCoroutine(player.transform.position));
            powerupCollect();
        }
        
    }

    void PopulatePowerUpsList()
    {
        //IA2-LINQ
        powerUps = powerUpParent.Cast<Transform>().Select(child => child.gameObject).ToList();
    }


    void powerupCollect()
    {
        //IA2-LINQ 
        var collected = powerUps.Where(p => p.activeSelf && Vector3.Distance(p.transform.position, player.transform.position) <= interactionRange).ToList();
        foreach (var powerup in collected)
        {
            //powerup.SetActive(false);
            collectedPowerUp.Add(powerup);
        }
    }

    void ListSpecificTypes()
    {
        //IA2-LINQ 
        var powerUpTypes = powerUps.Select(p => p.GetComponent<Pickup>()).OfType<Pickup>().ToList();
        candyList = powerUpTypes.Where(p => p.pickUpType == "Candy").Select(p => p.gameObject).ToList();
        powerList = powerUpTypes.Where(p => p.pickUpType == "Power").Select(p => p.gameObject).ToList();
    }

    public GameObject FindClosestPowerUp(Vector3 position)
    {
        //IA2-LINQ 
        return powerUps.OrderBy(p => Vector3.Distance(p.transform.position, position)).FirstOrDefault();
    }

    IEnumerator InteractWithClosestPowerUpCoroutine(Vector3 playerPosition)
    {
        UpdatePowerUpOrder(playerPosition);
        GameObject closestPowerUp = FindClosestPowerUp(playerPosition);
        if (closestPowerUp != null && Vector3.Distance(closestPowerUp.transform.position, playerPosition) <= interactionRange)
        {
            notificationText.text = "Power Up más cercano : " + powerUps[0].name;
            yield return new WaitForSeconds(5f);

        }

    }

    void UpdatePowerUpOrder(Vector3 playerPosition)
    {         //IA2-LINQ
         powerUps = powerUps.OrderBy(p => Vector3.Distance(p.transform.position, playerPosition)).ToList();
                     
    }
}

