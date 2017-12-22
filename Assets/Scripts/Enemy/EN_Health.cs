using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Defines Enemy Ship Health 
///Attach directly to the enemy ship object.
///Author: Eric Qian
///Since: 21 December 2017
public class EN_Health : MonoBehaviour {
	
	public const float MAX_HEALTH = 3f;
	public float hullHealth = MAX_HEALTH;
	private SpriteRenderer healthBar;

	// Use this for initialization
	void Start () {
		healthBar = GetComponentsInChildren<SpriteRenderer>()[1];
	}
	
	// Update is called once per frame
	void Update () {
		if (hullHealth <= 0) {
			Debug.Log ("Enemy Ship Destroyed");
			Destroy (this.gameObject);
		}

		healthBar.transform.localScale = new Vector3(hullHealth/MAX_HEALTH/2 , 0.5f, 1);
		healthBar.color = (hullHealth/MAX_HEALTH > .75f) ? Color.green : (hullHealth/MAX_HEALTH > .35f) ? Color.yellow : Color.red;
	}
}
