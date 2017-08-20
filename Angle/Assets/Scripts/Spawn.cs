using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {   
    public GameObject Eyellow, Egreen;
    public GameObject[] enemy;
    float speed = .1f;
    float time = 0f;
    


    // Use this for initialization
    void Start () {
        GameObject[] enemy = {Eyellow,Egreen};
        Instantiate(enemy[Random.Range(1, 4) - 1], transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] enemy = { Eyellow, Eyellow, Eyellow, Egreen, Egreen, Egreen, Egreen, Egreen, Egreen };
        time += Time.deltaTime;
       

        if (time > 8) {
            
            Instantiate(enemy[Random.Range(1, 11) - 1], transform.position, Quaternion.identity);
            time = 0;
        }
       

    }
}
