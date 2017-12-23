using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EN_Shooting : MonoBehaviour {

	public GameObject bulletPrefab;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = new Vector3(0f, -1f, 0f);
		StartCoroutine(simpleFire());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator simpleFire() {
		yield return new WaitForSeconds(2);
		Fire();
		StartCoroutine(simpleFire());
	}

	void Fire() {
		GetComponent<AudioSource>().Play();
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
			transform.position + pos,
            transform.rotation);
		bullet.AddComponent<Bullet> ();
        bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 1000);
        Destroy(bullet, 2.0f);
    }
}
