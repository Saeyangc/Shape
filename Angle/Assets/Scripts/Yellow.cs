using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour {

    public float speed = .2f;
    private Vector3 rot = new Vector3(0, 0, 1f);

    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(GameObject.Find("player").transform.position, rot, speed);
        transform.position = Vector2.MoveTowards(transform.position, GameObject.Find("Core").transform.position, speed * Time.deltaTime);

    }
}
