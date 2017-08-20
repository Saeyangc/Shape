using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    public Button Butn;   
    public Text t;
    

    void Start()
    {
        
        Button btn = Butn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnRelease);
        t.text = "Final Score: " + ScoreManage.score.ToString();

    }
    
   
    void TaskOnRelease()
    {
        SceneManager.LoadScene("game");        
        ScoreManage.score = 0;        

    }

    
}
