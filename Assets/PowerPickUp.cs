﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPickUp : MonoBehaviour, IPickUp {   
    public void PickUp(Charakter c)
    {
        c.OnPickUpEnter(this);
        Destroy(gameObject, 2f);
        gameObject.SetActive(false);
    }
}
