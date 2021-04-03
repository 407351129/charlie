using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    int time = 30;
    public Text time_UI;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer", 1, 1);
    }

    void timer()
    {
        time -=1;
        time_UI.text = time + "";
        if(time == 0)
        {
            time_UI.text = "0";
            CancelInvoke("timer");
        }
        
    }
}
