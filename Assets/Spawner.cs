using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Spawner : MonoBehaviour {

    
	// Use this for initialization
	void Start () {

        Scheduler.instance.Schedule(3, ()=> 
        {
            Spawn();
        });
        
	}	
    void Spawn()
    {
        var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.transform.position = new Vector3(0, 0.5f, 0);
    }
	
}
