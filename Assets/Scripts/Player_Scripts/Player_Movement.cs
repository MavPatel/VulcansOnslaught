using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed = 500f;
    Vector2 movement;
    private Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        movement = new Vector2(inputX, inputY);
        Movement(inputX,inputY,movement);
    }


    void Movement(float inputx, float inputy, Vector2 movement)
    {
        rigid.velocity = movement * speed * Time.fixedDeltaTime;
    }
}

