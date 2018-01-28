using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour {


    public float speed = 2;
    private Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

         float moveHoritzontal = 0f;

         float moveVertical = 0f;

         moveHoritzontal = Input.GetAxis("Horizontal");
         moveVertical = Input.GetAxis("Vertical");

         Vector2 movement = new Vector2(moveHoritzontal, moveVertical);

         rb.AddForce(movement * speed);
        


    }



}
