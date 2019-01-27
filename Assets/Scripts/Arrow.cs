using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
    PlayerHealth playerHealth;
    void Start()
    {
        GameObject controller = GameObject.FindWithTag("GameController");
        playerHealth = controller.GetComponent<PlayerHealth>();
        Object.Destroy(this.gameObject, 2.0f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerHealth.TakeDamage(20f);
            Object.Destroy(this.gameObject);
        }
    }
}
