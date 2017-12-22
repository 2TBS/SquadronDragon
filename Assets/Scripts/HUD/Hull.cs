using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hull : MonoBehaviour {
	public Sprite emptyPellet;
	public Sprite fullPellet;
	GameObject health;
	GameObject healthPellet1;
	GameObject healthPellet2;
	GameObject healthPellet3;
	GameObject healthPellet4;
	GameObject healthPellet5;
	PL_Health healthController;
	// Use this for initialization
	void Start () {
		//emptyPellet = Resources.Load("EmptyHealthPellet", typeof(Sprite)) as Sprite;
		//fullPellet = Resources.Load("FullHealthPellet", typeof(Sprite)) as Sprite;
		health = GameObject.Find ("PlayerShip");
		healthPellet1 = GameObject.Find ("FullHealthPellet (1)");
		healthPellet2 = GameObject.Find ("FullHealthPellet (2)");
		healthPellet3 = GameObject.Find ("FullHealthPellet (3)");
		healthPellet4 = GameObject.Find ("FullHealthPellet (4)");
		healthPellet5 = GameObject.Find ("FullHealthPellet (5)");
		healthController = health.GetComponent <PL_Health> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (healthController.hullHealth / 2 > 4) {
			healthPellet1.GetComponent<Image> ().sprite = fullPellet;
			healthPellet2.GetComponent<Image> ().sprite = fullPellet;
			healthPellet3.GetComponent<Image> ().sprite = fullPellet;
			healthPellet4.GetComponent<Image> ().sprite = fullPellet;
			healthPellet5.GetComponent<Image> ().sprite = fullPellet;
		} else if (healthController.hullHealth / 2 > 3) {
			healthPellet1.GetComponent<Image> ().sprite = fullPellet;
			healthPellet2.GetComponent<Image> ().sprite = fullPellet;
			healthPellet3.GetComponent<Image> ().sprite = fullPellet;
			healthPellet4.GetComponent<Image> ().sprite = fullPellet;
			healthPellet5.GetComponent<Image> ().sprite = emptyPellet;
		} else if (healthController.hullHealth / 2 > 2) {
			healthPellet1.GetComponent<Image> ().sprite = fullPellet;
			healthPellet2.GetComponent<Image> ().sprite = fullPellet;
			healthPellet3.GetComponent<Image> ().sprite = fullPellet;
			healthPellet4.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet5.GetComponent<Image> ().sprite = emptyPellet;
		} else if (healthController.hullHealth / 2 > 1) {
			healthPellet1.GetComponent<Image> ().sprite = fullPellet;
			healthPellet2.GetComponent<Image> ().sprite = fullPellet;
			healthPellet3.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet4.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet5.GetComponent<Image> ().sprite = emptyPellet;
		} else if (healthController.hullHealth / 2 > 0) {
			healthPellet1.GetComponent<Image> ().sprite = fullPellet;
			healthPellet2.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet3.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet4.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet5.GetComponent<Image> ().sprite = emptyPellet;
		} else {
			healthPellet1.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet2.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet3.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet4.GetComponent<Image> ().sprite = emptyPellet;
			healthPellet5.GetComponent<Image> ().sprite = emptyPellet;
		}
	}
}
