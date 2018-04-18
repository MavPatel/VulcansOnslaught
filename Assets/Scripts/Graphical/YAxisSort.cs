using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxisSort : MonoBehaviour {

    private SpriteRenderer sprite;
    public int Offset;
    public Transform parent;
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
        parent = GetComponentInParent<Transform>();
	}
	
	
	void LateUpdate () {
        //sprite.sortingOrder = (Mathf.RoundToInt(transform.position.y * 100f) * -1) + Offset;
        int pos = Mathf.RoundToInt(parent.position.y);
        pos /= 3;
        sprite.sortingOrder = (pos * -1) + Offset;
    }
}
