using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public float startingHealth = 100f;
	public float currentHealth;
	public Slider healthSlider;

	PlayerMovement playerMovement;
	PlayerMorph playerMorph;
	bool isDead;

	// Use this for initialization
	void Start () {
		playerMovement = GetComponent <PlayerMovement> ();
		playerMorph = GetComponent <PlayerMorph> ();
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage (float amount) {
		currentHealth -= amount;
		healthSlider.value = currentHealth;
	}	
}
