using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RotateToMouse : MonoBehaviour {

    float speed = 10f;
	
	// Update is called once per frame
	private void Update () {

        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


    }
}
