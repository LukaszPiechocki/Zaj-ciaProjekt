using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public float delay = 5;
    Action a = () => { Debug.Log("Yo"); };
    void Start ()
    {
        Scheduler.instance.Schedule(delay, a);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
