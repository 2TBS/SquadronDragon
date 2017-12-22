using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log (col.gameObject.ToString ());
		if(col.gameObject.name == "EnemyShip(Clone)")
		{
			Debug.Log ("Hit Enemy");
			Debug.Log (col.gameObject.ToString ());
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
	}
}
