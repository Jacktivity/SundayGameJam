﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed;

    private Collider playerCollider;
    private Rigidbody2D rb2d; 
    
    void Start()
    {
        playerCollider = GetComponent<Collider>();
        rb2d = GetComponent<Rigidbody2D> ();
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }


    private bool IsCharacterOffScreen()
    {
        return true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal * speed, moveVertical * speed);

        bool isOnScreen = IsCharacterOffScreen();

        if(isOnScreen)
        {
            rb2d.position += movement;
        }
        else
        {
            //put back on screen
        }
        
    }




}