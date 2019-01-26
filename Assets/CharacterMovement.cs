using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float speed;
    [SerializeField] private bool isBat = false;


    //Delegates
    public delegate void OnPlayerKilled();

    //Events
    public event OnPlayerKilled PlayerKilled;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        this.transform.Translate(movement * speed * Time.deltaTime, Space.World);

        if (Input.GetButtonDown("Fire1"))
        {
            isBat = !isBat;
            this.transform.Find("Cylinder").gameObject.SetActive(!isBat);
            this.transform.Find("Sphere").gameObject.SetActive(isBat);
            if (isBat)
            {
                speed = 20f;
            }
            else
            {
                speed = 5f;
            }
        }
    }
}
