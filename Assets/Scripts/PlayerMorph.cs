using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMorph : MonoBehaviour {
	[SerializeField] private bool isBat = false;
	PlayerMovement playerMovement;
	PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
		playerMovement = GetComponent <PlayerMovement> ();
		playerHealth = GetComponent <PlayerHealth> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (playerHealth.currentHealth > 0 && isBat) {
			playerHealth.TakeDamage (0.1f);
		}
	}

	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			isBat = !isBat;
			this.transform.Find ("VampireOrient").gameObject.SetActive (!isBat);
			this.transform.Find ("Bat").gameObject.SetActive (isBat);
			if (isBat) {
				playerMovement.speed = 4f;
			} else {
				playerMovement.speed = 2f;
			}
		}
	}
}
