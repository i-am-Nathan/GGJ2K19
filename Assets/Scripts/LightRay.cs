using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRay : MonoBehaviour {

    [SerializeField] private float castingRadius = 50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
                
        RaycastHit sphereHit;
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.down));
        if(Physics.Raycast(ray, out sphereHit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down)* sphereHit.distance, Color.yellow);
            if (sphereHit.collider.gameObject.CompareTag("Player"))
            {
                sphereHit.collider.gameObject.GetComponent<PlayerHealth>().TakeDamage(0.08f);
            }
        }
    }
}
