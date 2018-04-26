using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    private Transform player;
    private float boundX = 2f;
    private float boundY = 2f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate ()
    {

        transform.position = new Vector3(player.position.x,player.position.y,player.position.z - 10f);    

    }
}
