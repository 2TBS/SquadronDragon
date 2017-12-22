using System.Collections;
using System.Collections.Generic;
using UnityEngine;	

public class PL_Shooting : MonoBehaviour {

<<<<<<< HEAD
	public int ammo = 5;
	public const int DELAY = 1;
=======
	public const float DELAY = 0.3f;
>>>>>>> 406660f8c0b4ad21c5c7af9fcd57f8380079d438
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	int angle;
	Vector3 pos;
	double fireTimer = 0.0;

	// Use this for initialization
	void Start () {
		pos = new Vector3(0f, 2.1f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		fireTimer += Time.deltaTime;
<<<<<<< HEAD
		if (ammo == 0) {ammo = 5;}
		if (fireTimer > DELAY && Input.GetButtonDown ("Fire1")) {
=======
		if (fireTimer > DELAY && Input.GetButton ("Fire1")) {
>>>>>>> 406660f8c0b4ad21c5c7af9fcd57f8380079d438
			Fire ();
			fireTimer = 0.0;
		} 
		else if (fireTimer > DELAY && Input.GetButton ("Fire1")) {
			Debug.Log ("Weapon Cooldown (Time Remaining): " + (DELAY - fireTimer).ToString());
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
		ammo--;
	}
}
