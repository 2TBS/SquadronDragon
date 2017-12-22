using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Defines Bullet Actions
///Attach directly to the bullet object. Hint: use AddComponent<Bullet> ();
///Author: Eric Qian
///Since: 21 December 2017
public class Bullet : MonoBehaviour {

	public const int DAMAGE = 1;
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
			col.gameObject.GetComponent<EN_Health> ().hullHealth -= DAMAGE;
			Debug.Log ("Enemy Health Remaining: " + col.gameObject.GetComponent<EN_Health> ().hullHealth);
			Destroy (this.gameObject);
		}
		if(col.gameObject.name == "PlayerShip")
		{
			Debug.Log ("Hit player");
			Debug.Log (col.gameObject.ToString ());
			col.gameObject.GetComponent<PL_Health> ().hullHealth -= DAMAGE;
			Debug.Log ("Player Health Remaining: " + col.gameObject.GetComponent<PL_Health> ().hullHealth);
			Destroy (this.gameObject);
		}
	}
}
