﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdcontrol : MonoBehaviour
{
    private bool isDead = false;
    public float upforce = 200f;
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { if(isDead == false)
        {
            if(Input.GetMouseButtonDown (0))
            {

                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upforce));
                anim.SetTrigger("Flap");
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        gamecontroller.instance.BirdDied();
    }
}
