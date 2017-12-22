﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Defines the behavior for player movement (left-right and turning).
///Attach directly to the player object.
///Author: Ben Cuan
///Since: 19 December 2017
public class PL_Movement : MonoBehaviour {

	public const float MOVE_SPEED = 0.1f;
	public const float ROT_SPEED = 0.5f;
	public const float MAX_ROTATION = 30;

	private float currAngle = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.A) && transform.position.x > -Vars.MAX_WIDTH)
			transform.Translate(Vector3.left * MOVE_SPEED, Space.World);
		if(Input.GetKey(KeyCode.D) && transform.position.x < Vars.MAX_WIDTH)
			transform.Translate(Vector3.right * MOVE_SPEED, Space.World);
		if(Input.GetKey(KeyCode.Q) && currAngle > -MAX_ROTATION) {
            transform.Rotate(new Vector3(0,0,ROT_SPEED));
			currAngle -= ROT_SPEED;
		}
		if(Input.GetKey(KeyCode.E) && currAngle < MAX_ROTATION) {
            transform.Rotate(new Vector3(0,0,-ROT_SPEED));
			currAngle += ROT_SPEED;
		}
	}
}