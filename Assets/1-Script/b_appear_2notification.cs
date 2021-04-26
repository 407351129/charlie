using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class b_appear_2notification : MonoBehaviour
{
    public GameObject b_appear_notice;

    public GameObject b_disappear_notice;

    public static bool people_appear;

    // public string scene;
    // bool map_appear;
    // private bool left_is_press;
    public bool b_appear;

    public bool b_disappear;

    [SerializeField]
    private bool click;

    // private bool fight_notice;
    void Start()
    {
        click = false;
        people_appear = true;
        b_appear = false;
        b_disappear = false;
    }

    void Update()
    {
        // if (fight_notice == true)
        // {
        // speak_b_appear_on();
        // food_speak_click();
        speak_b_appear_on();
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
            people_appear = false;
            b_appear_notice.SetActive(true);
            b_disappear_notice.SetActive(false);
        }
        else
        {
            people_appear = true;
            b_appear_notice.SetActive(false);
            b_disappear_notice.SetActive(true);
        }
        people_appear = true;
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

    void speak_b_appear_on()
    {
        // test2 = false;
        // notification.SetActive(true);
        //if (AzureSpeech.message.Contains("直走") == true)
        {
            if (click == true)
            {
                b_appear = true;
                b_disappear = true;

                // click = false;
                return;
            }
        }
    }

    public void food_speak_click()
    {
        click = true;
        return;
        // }
        // speak_b_appear_on();
        // click = false;
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
