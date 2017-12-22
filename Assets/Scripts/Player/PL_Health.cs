using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Defines Player Health 
///Attach directly to the player object.
///Author: Eric Qian
///Since: 21 December 2017
public class PL_Health : MonoBehaviour {

	public int hullHealth = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hullHealth <=0) {
			Debug.Log ("Player Ship Destroyed");
			Destroy (this.gameObject);
		}
	}
}
