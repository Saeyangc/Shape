﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {
    Text txt;
	// Use this for initialization
	void Start () {
        txt.text = ScoreManage.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
