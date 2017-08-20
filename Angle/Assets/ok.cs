using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ok : MonoBehaviour {

    public Button Butn;
    public GameObject instpanel;

    void Start()
    {
        Button btn = Butn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnRelease);
    }

    void TaskOnRelease()
    {
        instpanel.gameObject.SetActive(false);
    }
}

