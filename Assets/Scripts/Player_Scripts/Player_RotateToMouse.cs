using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RotateToMouse : MonoBehaviour {

    float speed = 10f;
	
	// Update is called once per frame
	private void Update () {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x,mousePosition.y - transform.position.y);

        transform.up = direction;
        



	}
}
