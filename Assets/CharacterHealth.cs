using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour {
	public float startingHealth = 100f;
	public float currentHealth;
	public Slider healthSlider;

	CharacterMovement characterMovement;
	CharacterMorph characterMorph;
	bool isDead;

	// Use this for initialization
	void Start () {
		characterMovement = GetComponent <CharacterMovement> ();
		characterMorph = GetComponent <CharacterMorph> ();
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
