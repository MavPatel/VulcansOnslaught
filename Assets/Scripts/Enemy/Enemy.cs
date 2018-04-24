using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health;
    public  int attackSpeed;
    public int damage;
    public int moveSpeed;
    public int movementNumber = 0;


    public void ChangeHealth(int ammount)
    {
        health -= ammount;

        if (health <= 0)
        {
            Destroy(gameObject);
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
