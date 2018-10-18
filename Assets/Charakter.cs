using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Charakter : MonoBehaviour
{
    public int Health, Ammo;
    public bool IsInvicible;

    public void OnPickUpEnter(AmmoPickUp ammo)
    {
        Ammo += 20;
    }
    public void OnPickUpEnter(HealthPickUp health)
    {
        Health += 50;
    }
    public void OnPickUpEnter(PowerPickUp power)
    {
        IsInvicible = true;
        
        Scheduler.instance.Schedule(3,()=>
        {            
            IsInvicible = false;
        });
        //Health += 50;
        //Ammo += 20;
    }
    public void OnTriggerEnter(Collider collider)
    {
        var pickup = collider.GetComponent<IPickUp>();

        if (pickup != null)
        {
            pickup.PickUp(this);
        }

    }


}
