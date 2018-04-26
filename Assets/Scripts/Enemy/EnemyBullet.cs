﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public float speed = 500;
    private Transform player;
    private Vector2 target;
    private Rigidbody2D rigid;
    GameManagerScript game;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rigid = GetComponent<Rigidbody2D>();
        target = new Vector2(player.position.x, player.position.y);
        game = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManagerScript>();
    }

    private void Update()
    {
        rigid.MovePosition(Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime));
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enviroment" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Player")
        {
            game.SetHealth(-1, 1);
        }
    }
}
