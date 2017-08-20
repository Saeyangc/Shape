using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
    public Button Butn;
    // Use this for initialization
    void Start () {
        Button btn = Butn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnRelease);
    }

    void TaskOnRelease()
    {
        Application.Quit();
    }
}
