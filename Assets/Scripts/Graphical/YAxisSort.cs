using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxisSort : MonoBehaviour {

    private SpriteRenderer sprite;
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	
	void LateUpdate () {
        sprite.sortingOrder = (int)transform.position.y;
	}
}
