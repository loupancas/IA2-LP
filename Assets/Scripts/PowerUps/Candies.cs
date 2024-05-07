using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candies : Pickup
{
    public int value;
    
    public override void Activate()
    {
        Debug.Log("Candy");
        GameManager.instance.AddCandy(value);


    }

}
