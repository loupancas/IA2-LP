using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPower : Pickup
{
    public int Modifier=2;
    public override void Activate()
    {
        Debug.Log("speed buff");
        PowerUpAbilities.Get().speedPowerUp(Modifier);
    }
}
