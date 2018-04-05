using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animator : MonoBehaviour {

    private Animator bodyAnim;
    private Animator feetAnim;
	void Start () {

        bodyAnim = GetComponent<Animator>();
        feetAnim = GetComponentInChildren<Animator>();
	}
	
	
	void Update () {
		
	}
}
