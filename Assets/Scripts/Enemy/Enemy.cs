using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    
    public int health;
    public  int attackSpeed;
    public int damage;
    public int moveSpeed;
    public int movementNumber = 0;
    private Rigidbody2D rigid;
    public Transform target;
    private Animator anim;

    public void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }


    public void ChangeHealth(int ammount)
    {
        health -= ammount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
       
    }

    

    public void Update()
    {










        if (Vector3.Distance(transform.position,target.position) < 100)
        {

            Vector2 direction = target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;

            anim.SetFloat("x", angle);
            anim.SetFloat("y", angle);

            anim.SetBool("isWalking", true);
            rigid.MovePosition(Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime));

        }
        else
        {
            anim.SetBool("isWalking", false);
        }

    }
  

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
            
            ChangeHealth(collision.gameObject.GetComponent<Bullet>().damage);
            Debug.Log(health);
        }
    }

    

}
