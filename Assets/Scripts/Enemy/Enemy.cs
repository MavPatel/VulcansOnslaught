using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    
    public int health;
    public  int attackSpeed;
    public int damage;
    public int moveSpeed;
    public int movementNumber = 0;
    public bool triggered = false;
    private Rigidbody2D rigid;


    public void Awake()
    {
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

    public void Trigger(GameObject target)
    {
        triggered = true;
        
        transform.position += (target.transform.position - transform.position).normalized * moveSpeed * Time.deltaTime;
    }

    public void Chill()
    {
        triggered = false;
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
