using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxisSort : MonoBehaviour {

    private SpriteRenderer sprite;
    public int Offset;
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	
	void LateUpdate () {
        sprite.sortingOrder = (Mathf.RoundToInt(transform.position.y * 100f) * -1) + Offset;
    }
}
