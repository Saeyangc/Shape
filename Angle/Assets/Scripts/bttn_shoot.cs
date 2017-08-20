using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bttn_shoot : MonoBehaviour
{
    public GameObject sprite;
    public Button yourButton; 
    private Vector2 pos;
    private Quaternion rot;    
   

    void Start()
    {
        
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnRelease);
        

    }
     void FixedUpdate()
    {        
        pos = GameObject.Find("point").transform.position;
        rot = GameObject.Find("player").transform.rotation;
    }
    void TaskOnRelease()
    {
        GameObject lazer = Instantiate(sprite, pos, rot);
    }
}
   



