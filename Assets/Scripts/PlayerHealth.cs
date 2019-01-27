using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    //Delegates
    public delegate void OnPlayerKilled();

    //Events
    public event OnPlayerKilled PlayerKilled;

    public float startingHealth = 100f;
	public float currentHealth;
	public Slider healthSlider;

	PlayerMovement playerMovement;
	PlayerMorph playerMorph;
	bool isDead;

    private Renderer _renderer;
    private ParticleSystem.EmissionModule particleSystem;


	// Use this for initialization
	void Start () {
		playerMovement = GetComponent <PlayerMovement> ();
		playerMorph = GetComponent <PlayerMorph> ();
        particleSystem = GetComponent<ParticleSystem>().emission;
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage (float amount) {
        particleSystem.enabled = true;
        currentHealth -= amount;
		healthSlider.value = currentHealth;
   
        if(healthSlider.value <= 0f)
        {
            Debug.Log("GAMEOBER");
            //PlayerKilled();
        }
        particleSystem.enabled = false;
	}	
    
    IEnumerator Flasher()
    {

        yield return new WaitForSeconds(.1f);

    }
}
