﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RotateToMouse : MonoBehaviour {

	


    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation =  rotation;

    }
    
}
