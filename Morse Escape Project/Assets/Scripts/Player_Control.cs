using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class Player_Control : MonoBehaviour {


    public float speed = 0.04f;
    private Rigidbody2D rb;


    // Use this for initialization
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector2.right * speed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed);

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed);

        }

    }

    void Interact() {

        if (Input.GetKey(KeyCode.K))
        {

            //if (GetComponentInChildren<Sound_Byte>)
        }
        }
    }




