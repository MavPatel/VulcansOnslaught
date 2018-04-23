using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed = .2f;
    public float velocity;
    Vector2 movement;
    private Rigidbody2D rigid;
    private Animator anim;
    public Animator animHead;
    private SpriteRenderer sprRend;
    public SpriteRenderer feetRend;

    private bool right = true;
    private bool left = false;
    private bool down = true;
    private bool up = false;
    private void Start()
    {
       
        rigid = GetComponent<Rigidbody2D>();
        sprRend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
       
        Movement();
        MouseAnim();
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

        if (inputX > 0 || inputX < 0 || inputY > 0 || inputY < 0)
        {
            anim.SetFloat("x", inputX);
            anim.SetFloat("y", inputY);
        }
     

        if(velocity > 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        
       
    }

    void MouseAnim()
    {
       
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90;


        
        animHead.SetFloat("x", (angle / 90));
        animHead.SetFloat("y", (angle / 90));

    }

 
}

