using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour {
    public static int score = 0;
    public Text txt;
    float t = 0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        if (t > 1) { score++;
            t = 0; }
        
        txt.text = score.ToString();
	}
}
