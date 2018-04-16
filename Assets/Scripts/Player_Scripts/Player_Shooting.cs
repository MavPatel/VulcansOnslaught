using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour {

    public GameObject bullet;
    public float velocity;
    public float spread;
    public bool canShoot;
    public float waitTime = 0.1f;
    public Transform BulletSpawner;
    [SerializeField]
    private float charge;
    public float chargeAdder;
    [SerializeField]
    private float timer;
    [SerializeField]
    private float MaxTimer = 1f;

	// Use this for initialization
	void Start () {
        velocity =  Random.Range(500f, 1000f);
        spread = Random.Range(0f, 1f);
        canShoot = true;
	}
	

	void Update () {


        if (Input.GetMouseButton(1))
        {
            charge += 0.1f;

            if (charge >= MaxTimer)
                charge = MaxTimer;

            if(charge >= MaxTimer)
            {
                Debug.Log("Charged");
            }




        }

        if (Input.GetMouseButtonUp(1) && charge >= MaxTimer)
        {
            charge = 0f;
            Debug.Log("Fired");
            StartCoroutine(MakeBullet(new Vector3(20, 20, 1)));
        }else if(Input.GetMouseButtonUp(1) && charge < MaxTimer)
        {
            charge = 0f;
            
        }
        

        else if(Input.GetMouseButton(0) && canShoot && !Input.GetMouseButton(1))
        {
            StartCoroutine(MakeBullet(new Vector3(5,5,1)));
        }
	}

    public IEnumerator MakeBullet(Vector3 scale)
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        direction.Normalize();
        GameObject CBullet = (GameObject)Instantiate(bullet, transform.position, rotation);
        CBullet.transform.localPosition = BulletSpawner.transform.position;
        CBullet.transform.localScale = scale;
        CBullet.GetComponent<Rigidbody2D>().velocity = direction * velocity;
        canShoot = false;
        yield return new WaitForSeconds(waitTime);
        canShoot = true;
    }
}
