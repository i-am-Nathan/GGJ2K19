﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
 
	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag = "Player")
        {
            //TODO: Decrease the health of player
        }
    }
}
