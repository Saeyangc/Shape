using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lazer : MonoBehaviour
{
          float speed = 100f;
    
    void Start()
    {       
        
    }
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * speed);
        GameObject l = gameObject;
        Destroy(l, 1);        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Eyellow(Clone)"|| collision.gameObject.name == "Egreen(Clone)") {
            GameObject l = gameObject;           
            Destroy(collision.gameObject);
            Destroy(l);           
            
        }
    }

}