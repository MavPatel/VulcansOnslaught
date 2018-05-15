using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public float speed = 500;
    private Transform player;
    private Vector2 target;
    private Rigidbody2D rigid;
    GameManagerScript game;
    //god is dead
   
    
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        rigid = GetComponent<Rigidbody2D>();
        target = new Vector2(player.position.x, player.position.y);
        game = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManagerScript>();
    }

    private void Update()
    {
        
        transform.position = (Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime));

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enviroment")
        {
            Destroy(gameObject);
        }else if (collision.gameObject.tag == "Player")
        {
            game.SetHealth(-1, 1);
            Destroy(gameObject);
        }
       
    }
     
    
}
