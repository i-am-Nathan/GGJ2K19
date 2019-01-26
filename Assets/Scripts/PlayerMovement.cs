using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;


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

    }
}
