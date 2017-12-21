using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EN_Movement : MonoBehaviour {

	public const float MOVE_SPEED = 0.1f;
	bool movingLeft = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(movingLeft)
			transform.Translate(Vector2.left * MOVE_SPEED);
		else
			transform.Translate(Vector2.right * MOVE_SPEED);

		if(transform.position.x < -Vars.MAX_WIDTH || transform.position.x > Vars.MAX_WIDTH)
			movingLeft = !movingLeft;
	}
}
