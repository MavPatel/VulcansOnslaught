using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : MonoBehaviour {

    private Skeleton skeleton;
	
	void Start () {
        skeleton = GetComponentInParent<Skeleton>();
        
	}


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            skeleton.Trigger(collision.gameObject);
        }else if (skeleton.triggered)
        {
            skeleton.Trigger(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            skeleton.Chill();
        }
    }
}
