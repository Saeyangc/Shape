using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    public float speed = .2f;
    void Start() { }

    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position,GameObject.Find("Core").transform.position ,speed * Time.deltaTime);
    }
}
