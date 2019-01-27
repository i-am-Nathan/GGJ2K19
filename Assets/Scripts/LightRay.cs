using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRay : MonoBehaviour {

    [SerializeField] private float castingRadius = 50f;

    private Transform parent;
    private float rayLength;

	// Use this for initialization
	void Start () {
        parent = gameObject.GetComponentInParent<Transform>();
        rayLength = Vector3.Distance(gameObject.transform.position, parent.position);

	}
	
	// Update is called once per frame
	void Update () {
                
        RaycastHit sphereHit;
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.down));
        if(Physics.Raycast(ray, out sphereHit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down)* sphereHit.distance, Color.yellow);
            if (sphereHit.collider.gameObject.CompareTag("Player"))
            {
                sphereHit.collider.gameObject.GetComponent<PlayerHealth>().TakeDamage(0.1f);
            }
        }
    }
}
