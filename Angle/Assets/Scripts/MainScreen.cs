using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour {
    public Button Butn;
    // Use this for initialization
    void Start()
    {
        Button btn = Butn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnRelease);        
    }

    // Update is called once per frame
    void Update () {
		
	}
    void TaskOnRelease()
    {
        SceneManager.LoadScene("game");
    }

}
