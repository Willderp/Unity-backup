﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Manger : MonoBehaviour {

    int score;
    public Text scoretext;

	// Use this for initialization
	void Start () {
        score = 0;
        scoretext.text = "Score: " + score;
	}
	
	void UpdateScore(int amount)
    {
        score = score + amount;
        scoretext.text = "Score: " + score;
    }
}