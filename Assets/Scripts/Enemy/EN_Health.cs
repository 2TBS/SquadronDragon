using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Defines Enemy Ship Health 
///Attach directly to the enemy ship object.
///Author: Eric Qian & Vikram Peddinti
///Since: 21 December 2017
public class EN_Health : MonoBehaviour {
	
	public float maxHealth = 3f;
	public float hullHealth;
    public int scoreModifier;
	private SpriteRenderer healthBar;

	// Use this for initialization
	void Start () {
		healthBar = GetComponentsInChildren<SpriteRenderer>()[1];
		hullHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (hullHealth <= 0) {
			Debug.Log ("Enemy Ship Destroyed");
            PL_Score.score += scoreModifier;
			Destroy (this.gameObject);
		}

		healthBar.transform.localScale = new Vector3(hullHealth/maxHealth/2 , 0.5f, 1);
		healthBar.color = (hullHealth/maxHealth > .75f) ? Color.green : (hullHealth/maxHealth > .35f) ? Color.yellow : Color.red;
	}
}
