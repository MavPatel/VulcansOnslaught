using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour {

    public GameObject bullet;
    public float velocity;
    public float spread;
    public bool canShoot;
    public float waitTime = 0.1f;
	// Use this for initialization
	void Start () {
        velocity =  Random.Range(500f, 1000f);
        spread = Random.Range(0f, 1f);
        canShoot = true;
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButton(0) && canShoot)
        {


            StartCoroutine(MakeBullet());

        }
	}

    public IEnumerator MakeBullet()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        direction.Normalize();
        GameObject CBullet = (GameObject)Instantiate(bullet, transform.position, rotation);
        CBullet.transform.localPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 20);
        CBullet.GetComponent<Rigidbody2D>().velocity = direction * velocity;
        canShoot = false;
        yield return new WaitForSeconds(waitTime);
        canShoot = true;
    }
}
