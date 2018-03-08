using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed = 20.5f;
    Vector2 movement;
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        movement = new Vector2(inputX, inputY);
        Movement(inputX,inputY,movement);
    }


    void Movement(float inputx, float inputy, Vector2 movement)
    {
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

