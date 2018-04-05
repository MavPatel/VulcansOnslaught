﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed = .2f;
    public float velocity;
    Vector2 movement;
    private Rigidbody2D rigid;
    private Animator bodyAnim;
    public Animator feetAnim;
    private SpriteRenderer sprRend;
    public SpriteRenderer feetRend;

    private bool right = true;
    private bool left = false;
    private bool down = true;
    private bool up = false;
    private void Start()
    {
        bodyAnim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        sprRend = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        Animate();
        Movement();
    }


    void Movement()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
       

        if(Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Horizontal") < 0 || Input.GetAxisRaw("Vertical") < 0)
        {
            velocity += speed;
        }
        else
        {
            velocity = 0;
        }

        velocity = Mathf.Clamp(velocity, 0, 100);
        movement = new Vector2(inputX, inputY);
        rigid.velocity = movement.normalized * velocity;

        if (Input.GetKey(KeyCode.S))
        {
            down = true;
            up = false;
            left = false;
            right = false;
        }else if (Input.GetKey(KeyCode.W))
        {
            up = true;
            down = false;
            left = false;
            right = false;
        }else if (Input.GetKey(KeyCode.A))
        {
            sprRend.flipX = true;
            feetRend.flipX = true;
            left = true;
            right = true;
            up = false;
            down = false;
        }else if (Input.GetKey(KeyCode.D))
        {
            sprRend.flipX = false;
            feetRend.flipX = false;
            right = true;
            down = false;
            up = false;
            left = false;
        }
    }

    void Animate()
    {
        bodyAnim.SetBool("FacingDown", down);
        bodyAnim.SetBool("FacingRight", right);
        feetAnim.SetBool("FacingRight", right);
        feetAnim.SetBool("FacingDown", down);
        feetAnim.SetFloat("Speed", velocity);
    }
}

