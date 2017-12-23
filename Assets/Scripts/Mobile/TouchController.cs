using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {
	
	GameObject playerShip;
	// Use this for initialization
	void Start () {
		playerShip = GameObject.Find ("PlayerShip");
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			HandleTouch (touch);
		}

		//Below is for Unity Editor Debugging(To emulate touch events.
		//Do not remove .isEditor if statement to prevent bad stuff from happening.
		if (Application.isEditor) {
			if (Input.GetMouseButton (0)) {
				Touch fakeTouch = new Touch ();
				fakeTouch.fingerId = 10;
				fakeTouch.position = Input.mousePosition;
				fakeTouch.deltaTime = Time.deltaTime;
				fakeTouch.deltaPosition = Input.mousePosition;
				fakeTouch.phase = (Input.GetMouseButtonDown (0) ? TouchPhase.Began : 
				(fakeTouch.deltaPosition.sqrMagnitude > 1f ? TouchPhase.Moved : TouchPhase.Stationary));
				fakeTouch.tapCount = 1;

				HandleTouch (fakeTouch);
			}
		}

	}

	void HandleTouch(Touch touch) {
		if (touch.position.x < Screen.width/2) {
			playerShip.GetComponent<PL_Movement> ().MoveLeft();
		}
		else if (touch.position.x > Screen.width/2) {
			playerShip.GetComponent<PL_Movement> ().MoveRight();
		} 
	}
}
