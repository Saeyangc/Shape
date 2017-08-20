using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.UIElements;

public class Paddle : MonoBehaviour {
    private float speed = 1f;
    public GameObject p;
    
    
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        p.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
           transform.Rotate(0,0, -touchDeltaPosition.x * speed);
         }

        if (transform.localScale.x < .05 ) {

            Time.timeScale = 0;
            p.gameObject.SetActive(true);
        }       
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Eyellow(Clone)" || col.gameObject.name == "Egreen(Clone)")
        {
            Destroy(col.gameObject);
            transform.localScale+= new Vector3(-.01f, -.01f, 0);
           
        }

        

    }
}
