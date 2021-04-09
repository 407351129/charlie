using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class appear_2notification : MonoBehaviour
{
    public GameObject appear_notice;

    public GameObject disappear_notice;

    // public string scene;
    // bool map_appear;
    // private bool left_is_press;
    public bool appear;

    public bool disappear;

    private bool fight_notice;

    void Update()
    {
        // if (fight_notice == true)
        // {
        // notification_on();
        appear_on();
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
        if (appear == true)
        {
            appear_notice.SetActive(true);
            disappear_notice.SetActive(false);
        }
        else
        {
            appear_notice.SetActive(false);
            disappear_notice.SetActive(true);
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
        fight_notice = people_map.fight_notice;
        if (fight_notice == true)
        {
            appear = true;
            disappear = true;
            notification_on();
        }

        return;
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
