using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL_Shooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Fire();
		}
		
	}

	void Fire() {
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			transform.position,
			transform.rotation);

		//bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 6;
		bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000);
		Destroy(bullet, 2.0f);     
	}
}
