using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Defines Enemy Ship Health 
///Attach directly to the enemy ship object.
///Author: Eric Qian
///Since: 21 December 2017
public class EN_Health : MonoBehaviour {
	
	public int hullHealth = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hullHealth <= 0) {
			Debug.Log ("Enemy Ship Destroyed");
			Destroy (this.gameObject);
		}
	}
}
