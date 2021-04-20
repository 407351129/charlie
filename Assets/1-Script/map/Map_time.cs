using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_time : MonoBehaviour
{
    public int map_time;

    public GameObject time_map;

    public GameObject time_map_monster;

    // public Text map_time_UI;
    // public static bool time_out;
    // public bool time_out_test;
    // public int time_test;
    public bool end_map;

    // public bool time_out_test;
    // Start is called before the first frame update
    private void Awake()
    {
        // if (people_map.fight_notice != true)
        // {
        //     Destroy(this.gameObject);
        //     return;
        // }
        // sfxInstance = this;
        //如果食物送完
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        map_time = 0;
        end_map = false;

        if (end_map == true)
        {
            CancelInvoke("timer");
        }
        else if (
            time_map.activeInHierarchy == true &&
            time_map_monster.activeInHierarchy == true
        )
        {
            InvokeRepeating("timer", 1, 1);
        }
        else
        {
            CancelInvoke("timer");
            Destroy(this.gameObject);

            // DestroyOnLoad(this);
        }
    }

    void timer()
    {
        map_time += 1;

        // if (end_map == true)
        // {
        //     map_time = 0;
        //     CancelInvoke("timer");
        // }
        // else if (
        //     time_map.activeInHierarchy == true &&
        //     time_map_monster.activeInHierarchy == true
        // )
        // {
        //     InvokeRepeating("timer", 1, 1);
        // }
        // else if (fight_on
        // )
        // {
        //     InvokeRepeating("timer", 1, 1);
        // }
        // else
        // {
        //     CancelInvoke("timer");
        //     // Destroy(this.gameObject);

        //     // DestroyOnLoad(this);
        // }
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

    // using System.Collections;
    // using System.Collections.Generic;
    // using UnityEngine;

    // public class SfxManager : MonoBehaviour
    // {
    //     public AudioSource Audio;
    //     public AudioClip start;
    //     public AudioClip UI_click;
    //     public AudioClip attack;
    //     public AudioClip levelup;
    //     public bool musicToggle = true;
    //     public static SfxManager sfxInstance;

    //     private void Awake()
    //     {
    //         if (sfxInstance != null && sfxInstance != this)
    //         {
    //             Destroy(this.gameObject);
    //             return;
    //         }
    //         sfxInstance = this;
    //         DontDestroyOnLoad(this);

    //     }
    // }
}
