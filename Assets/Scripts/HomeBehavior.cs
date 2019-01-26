using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBehavior : MonoBehaviour {

    //delegates
    public delegate void OnGoalMet();

    //events
    public event OnGoalMet VictoryTriggered;

	// Use this for initialization
	void Start () {
		
	}


    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") {
            VictoryTriggered();
        }
    }
}
