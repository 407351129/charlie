using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class appear_2notification : MonoBehaviour
{
    public GameObject appear_notice;

    public GameObject disappear_notice;

    private GameObject[] FoodAppear;

    // public string scene;
    // bool map_appear;
    // private bool left_is_press;
    public bool appear;

    public bool disappear;

    private bool fight_notice;

    public bool food_notice;

    private bool get_food;

    Transform Player;

    [SerializeField]
    int test_which;

    // [SerializeField]
    // int Map_which_map_pin;
    [SerializeField]
    private int map_pin_num;

    public static int which_map_pin;

    public static int time = 30;

    public Text time_UI;

    public static bool time_out;

    public bool time_out_test;

    public GameObject food;

    public GameObject monster;

    void Start()
    {
        // Player = gameObject.transform;
    }

    void Update()
    {
        time_out_test = time_out;
        if (food.activeInHierarchy == false)
        {
            time_out = false;
        }

        if (time_out == true)
        {
            food.SetActive(false);
            monster.SetActive(true);
        }
        // if (countdown.time_out == true)
        // {
        //     food_notice = false;
        // }
    }

    void notification_on()
    {
        // test2 = false;
        // notification.SetActive(true);
        appear_notice.SetActive(true);

        // if (disappear == false)
        // {
        //     // disappear_notice.SetActive(false);
        // }
        // else
        // {
        // appear_notice.SetActive(true);
        // disappear_notice.SetActive(true);
        // }
        if (appear_notice.activeInHierarchy == true)
        // &&
        // monster_mapwalk.which_monster != 0
        {
            disappear_notice.SetActive(false);
        }
    }

    void food_notification_on()
    {
        // test2 = false;
        // notification.SetActive(true);
        appear_notice.SetActive(true);

        // if (disappear == false)
        // {
        //     // disappear_notice.SetActive(false);
        // }
        // else
        // {
        // appear_notice.SetActive(true);
        // disappear_notice.SetActive(true);
        // }
        if (appear_notice.activeInHierarchy == true)
        // &&
        // monster_mapwalk.which_monster != 0
        {
            disappear_notice.SetActive(false);
        }
    }

    // void notification_off()
    // {
    //     if (disappear == true)
    //     {
    //         disappear_notice.SetActive(false);
    //     }
    //     else
    //     {
    //         disappear_notice.SetActive(true);
    //     }
    // }
    public void appear_on()
    {
        // disappear = true;
        // appear = true;
        // if_click = if_click.click_or_not;
        // fight_notice = people_map.fight_notice;
        // food_notice = people_map.food_notice;
        // if (fight_notice == true)
        // {
        // appear = true;
        // disappear = true;
        if (monster_mapwalk.which_monster != 0)
        {
            notification_on();
        } // appear = false; // disappear = false;
        if (food_notice == true && Map_food.get_food == false)
        {
            food_notification_on(); //想要放陣列appear_notice = GameObject.Find("monster1");
        }
        return;
    }

    void OnCollisionEnter2D(Collision2D c) //monster
    {
        if (c.gameObject.tag == "Player")
        {
            appear_on();
        }
    }

    void OnTriggerEnter2D(Collider2D c) //food
    {
        if (c.gameObject.tag == "Player")
        {
            food_notice = true;
            which_map_pin = map_pin_num;
            appear = true;
            disappear = true;
            start_time();
            appear_on();
            // m_wall = false;
            // return;
        }
    }

    void timer()
    {
        time -= 1;
        if (time == 0)
        {
            time_out = true;
            time_out_test = true;
            CancelInvoke("timer");
        }
        if (time != 30)
        {
            time_UI.text = time + "";
        }

        // time_test = time;
        // if (time == 0)
        // {
        //     time_UI.text = "0";

        //     // return;
        //     // CancelInvoke("timer");
        // }
    }

    void start_time()
    {
        CancelInvoke("timer");
        time = 30;
        time_out = false;
        if (time == 30)
        {
            time_UI.text = time + "";
        }
        InvokeRepeating("timer", 1, 1);
        time = 30;
    }

    void food_appear()
    {
        //如果人撞到食物
        //     public static bool food_notice;
        // [SerializeField]
        // bool test_food_notice;
    }

    // public void disappear_on()
    // {
    //     appear = false;
    //     disappear = true;
    //     return;
    // }
}

// void order(){
//     scene = "order";
//     map_appear = false;
// }
// public void which_scene()

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Die : MonoBehaviour
// {
//     public GameObject die;

//     public void EnableDie(bool enabled)
//     {
//         die.SetActive(enabled);
//     }
// }
