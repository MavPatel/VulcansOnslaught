using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {


    public int damage;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enviroment" || collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }


}
