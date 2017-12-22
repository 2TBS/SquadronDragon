using System.Collections;
using System.Collections.Generic;
using UnityEngine;	

public class PL_Shooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	int angle;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = new Vector3(0f, 2.1f, 0f);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
			Fire();
		}
		
	}

	void Fire() {
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			transform.position + pos,
			transform.rotation);
		bullet.AddComponent<Bullet> ();
		bullet.GetComponent<Rigidbody2D>().AddForce(transform.rotation * Vector2.up * 1000);
		Destroy(bullet, 2.0f);     
	}
}
