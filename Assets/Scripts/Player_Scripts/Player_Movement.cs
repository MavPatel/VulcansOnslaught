using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed = 5f;
    Vector2 movement;
    private Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        
        Movement();
    }


    void Movement()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(inputX, inputY);
        rigid.velocity = movement.normalized * speed;
    }
}

