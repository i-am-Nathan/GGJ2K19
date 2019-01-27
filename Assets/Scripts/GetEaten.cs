using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEaten : MonoBehaviour {
    PlayerHealth playerHealth;

    private void Start()
    {
        GameObject controller = GameObject.FindWithTag("GameController");
        playerHealth = controller.GetComponent<PlayerHealth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerHealth.TakeDamage(-30f);
            Destroy(gameObject);

        }
    }
}
