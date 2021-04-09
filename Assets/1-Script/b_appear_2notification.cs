using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class b_appear_2notification : MonoBehaviour
{
    public GameObject b_appear_notice;

    public GameObject b_disappear_notice;

    // public string scene;
    // bool map_appear;
    // private bool left_is_press;
    public bool b_appear;

    public bool b_disappear;

    // private bool fight_notice;
    void Start()
    {
        b_appear = false;
        b_disappear = false;
    }

    void Update()
    {
        // if (fight_notice == true)
        // {
        b_notification_on();
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

    void b_notification_on()
    {
        // test2 = false;
        // notification.SetActive(true);
        if (b_appear == true)
        {
            b_appear_notice.SetActive(true);
            b_disappear_notice.SetActive(false);
        }
        else
        {
            b_appear_notice.SetActive(false);
            b_disappear_notice.SetActive(true);
        }
        b_appear = false;
        b_disappear = false;
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
    public void b_appear_on()
    {
        // disappear = true;
        // appear = true;
        // if_click = if_click.click_or_not;
        b_appear = true;
        b_disappear = true;

        // b_notification_on();
        // return;
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
