using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour {

    private Transform target = null;
    FireArrow fireArrow;
    public float fireRate;
    float nextFire;

	// Use this for initialization
	void Start () {
        fireArrow = transform.gameObject.GetComponentInChildren<FireArrow>();
        nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null) return;
        transform.LookAt(target);

        if(Time.time> nextFire)
        {
            fireArrow.Shoot();
            nextFire = Time.time + fireRate;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") target = other.transform;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") target = null;
    }
    
}
