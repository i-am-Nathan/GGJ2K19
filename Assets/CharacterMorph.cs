using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMorph : MonoBehaviour {
	[SerializeField] private bool isBat = false;
	CharacterMovement characterMovement;
	CharacterHealth characterHealth;

	// Use this for initialization
	void Start () {
		characterMovement = GetComponent <CharacterMovement> ();
		characterHealth = GetComponent <CharacterHealth> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (characterHealth.currentHealth > 0 && isBat) {
			characterHealth.TakeDamage (0.1f);
		}

		if (Input.GetButtonDown("Fire1"))
		{
			isBat = !isBat;
			this.transform.Find("Human").gameObject.SetActive(!isBat);
			this.transform.Find("Bat").gameObject.SetActive(isBat);
			if (isBat)
			{
				characterMovement.speed = 20f;
			}
			else
			{
				characterMovement.speed = 5f;
			}
		}
	}
}
