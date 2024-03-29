﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed;
    public float health;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(transform.right * speed, ForceMode2D.Impulse);

        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy" | col.gameObject.tag =="Player")
        {
            col.gameObject.SendMessage("ApplyDamage", 10);
        }
    }
    void ApplyDamage(int n)
    {
        health = -n;
    }
}
