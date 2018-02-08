using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class Player_Control : MonoBehaviour
{


    public float speed = 0.04f;
    private Rigidbody2D rb;

    Animator anim;      // Jess added, testing anim for movement

    // Use this for initialization


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();    // Jess added, testing anim for movement
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            anim.Play("Char_Walk_Side");

        if (Input.GetKey(KeyCode.W))
            anim.Play("Char_Walk_Up");

        if (Input.GetKey(KeyCode.S))
            anim.Play("Char_Walk_Down");
        
        // Jess added, testing anim for movement

        if (Input.GetKey(KeyCode.D))
        {
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




}