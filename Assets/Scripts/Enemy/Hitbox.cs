using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

    private Skeleton skeleton;

    public void Start()
    {
        skeleton = GetComponentInParent<Skeleton>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {

            skeleton.ChangeHealth(collision.gameObject.GetComponent<Bullet>().damage);
            Debug.Log(skeleton.health);
        }
    }
}
