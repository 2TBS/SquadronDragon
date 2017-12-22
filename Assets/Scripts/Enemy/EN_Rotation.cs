using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EN_Rotation : MonoBehaviour {

	public float rotation;

	// Use this for initialization
	void Start () {
		if(rotation <= 0)
			rotation = Random.Range(-50, 50);
			transform.Rotate(new Vector3(0, 0, rotation));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
