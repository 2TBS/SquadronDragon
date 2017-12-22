using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EN_Spawn : MonoBehaviour {

	///Time between each enemy spawn, in seconds
	public const float SPAWN_RATE = 5;

	public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {
		StartCoroutine(Spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Spawn() {
		var ship = Instantiate(enemyPrefab, new Vector2(Random.Range(-Vars.MAX_WIDTH, Vars.MAX_WIDTH), Random.Range(0, Vars.MAX_HEIGHT)), Quaternion.identity);
		yield return new WaitForSeconds(SPAWN_RATE);
		StartCoroutine(Spawn());
	}
}
