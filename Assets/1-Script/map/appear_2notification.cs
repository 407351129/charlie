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

    void Start()
    {
        // Player = gameObject.transform;
    }

    void Update()
    {
        // if (b_appear_2notification.speak_get_food == true)
        // {
        //     food_notice = false;
        //     // which_map_pin = map_pin_num;
        //     appear = false;
        //     disappear = false;
        // }
        // if (fight_notice == true)
        // {
        // notification_on();
        // appear_on();
        // }
        // appear_on();
        // if (appear != false || disappear != true)
        // {
        //     appear = false;
        //     disappear = false;
        // }
        // notification_off();
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
        if (food_notice == true)
        {
            food_notification_on(); //想要放陣列appear_notice = GameObject.Find("monster1");
        }
        return;
    }

    void OnCollisionEnter2D(Collision2D c) //monster
    {
        if (c.gameObject.tag == "Player")
        {
            // appear_notice.SetActive(true);
            // test_which = 5555;
            appear_on();
            // at_corner = false;
            // Action_Controller.SetBool("at_corner", at_corner);
        }
        // if (c.gameObject.tag == "Food")
        // {
        //     Player.Translate(300, 4000, 0);
        //     // food_notice = true;
        // }
    }

    // void OnCollisionStay(Collider2D c)
    // {
    //     if (c.gameObject.tag == "Player")
    //     {
    //         // test_which = 5555;
    //         appear_on();
    //         // at_corner = false;
    //         // Action_Controller.SetBool("at_corner", at_corner);
    //     }
    // }
    void OnTriggerEnter2D(Collider2D c) //food
    {
        if (c.gameObject.tag == "Player")
        {
            food_notice = true;
            which_map_pin = map_pin_num;
            appear = true;
            disappear = true;

            appear_on();
            // m_wall = false;
            // return;
        }
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
