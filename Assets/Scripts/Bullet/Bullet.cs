using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Defines Bullet Actions
///Attach directly to the bullet object. Hint: use AddComponent<Bullet> ();
///Author: Eric Qian
///Since: 21 December 2017
public class Bullet : MonoBehaviour {

	public const float DAMAGE = 1f;
	public int durability = 3;
	public GameObject originObject;
	public string originObjectName;
	// Use this for initialization
	void Start () {
		if (originObject != null) {
			originObjectName = originObject.gameObject.name;
		} 
		else {
			originObjectName = "Destroyed";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log (col.gameObject.ToString ());
		durability--;

		if(col.gameObject.tag.Equals("Enemy"))
		{
			Debug.Log ("Hit Enemy");
			Debug.Log (col.gameObject.ToString ());
			if (originObject.gameObject.tag.Equals ("Enemy")) {
				//If Enemy Fire Hits Enemy - Regular Damage
				col.gameObject.GetComponent<EN_Health> ().hullHealth -= (DAMAGE);
			} else {
				//If Something else Fires Hits Enemy - Regular Damage
				col.gameObject.GetComponent<EN_Health> ().hullHealth -= DAMAGE;
			}
			Debug.Log ("Enemy Health Remaining: " + col.gameObject.GetComponent<EN_Health> ().hullHealth);
			//Destroy (this.gameObject);
		}
		if(col.gameObject.name == "PlayerShip")
		{
			Debug.Log ("Hit player");
			Debug.Log (col.gameObject.ToString ());
			if (originObjectName == "PlayerShip") {
				//Player Fire Hits Player - Half Damage
				col.gameObject.GetComponent<PL_Health> ().hullHealth -= (DAMAGE/2);
			} else {
				//Something else Fires Hits Player - Regular Damage
				col.gameObject.GetComponent<PL_Health> ().hullHealth -= DAMAGE;
			}
			Debug.Log ("Player Health Remaining: " + col.gameObject.GetComponent<PL_Health> ().hullHealth);
			//Destroy (this.gameObject);
		}
		if (durability <= 0) {
			Destroy (this.gameObject);
		}
	}
}
