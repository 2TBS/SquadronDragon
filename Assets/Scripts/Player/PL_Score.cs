﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///Simple scoring mechanism holding a variable and updating UI
///Vikram Peddinti
///Since: 23 December 2017
public class PL_Score:MonoBehaviour{

    public Text scoreText;

	// Use this for initialization
    void Start () {
		Vars.CURRENT_SCORE = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = Vars.CURRENT_SCORE.ToString();
	}
}
