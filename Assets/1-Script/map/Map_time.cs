using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_time : MonoBehaviour
{
    public int map_time;

    // public Text map_time_UI;
    // public static bool time_out;
    // public bool time_out_test;
    // public int time_test;
    public bool end_map;

    // public bool time_out_test;
    // Start is called before the first frame update
    void Start()
    {
        map_time = 0;
        end_map = false;

        if (end_map == true)
        {
            CancelInvoke("timer");
        }
        else
        {
            InvokeRepeating("timer", 1, 1);
        }
    }

    void timer()
    {
        map_time += 1;

        if (end_map == true)
        {
            CancelInvoke("timer");
        }
        // if (map_time == 0)
        // {
        //     time_out_test = true;
        //     // CancelInvoke("timer");
        // }
        // if (time != 30)
        // {
        //     time_UI.text = time + "";
        // }

        // map_time_test = map_time;
        // if (map_time == 0)
        // {
        //     map_time_UI.text = "0";

        //     // return;
        //     // CancelInvoke("map_timer");
        // }
    }

    public void StartTimeCount()
    {
        // if (button_fi.fight_on == true)
        // {
        // map_time = 0;
        // if (map_time == 0)
        // {
        //     map_time_UI.text = time + "";
        // }
        // map_time = 30;
        // time_out_test = time_out;
        // // if (time == 0)
        // {
        //     time_out_test = true;
        // }
        // time_test = time;
        // }
    }
}
