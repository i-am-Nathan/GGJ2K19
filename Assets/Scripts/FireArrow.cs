using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArrow : MonoBehaviour {
    public GameObject arrow;
    public float arrowSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Shoot()
    {
        GameObject projectile = Instantiate(arrow, transform.position, transform.rotation) as GameObject;
        projectile.GetComponent<Rigidbody>().AddForce(transform.forward * arrowSpeed);


    }
}
