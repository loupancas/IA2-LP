using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPower : Pickup
{
    public float Modifier=1.8f;
    public override void Activate()
    {
        Debug.Log("jump");

        PowerUpAbilities.Get().jumpPowerUp(Modifier);
    }

   
}
