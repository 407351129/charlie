using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transportation_appear : MonoBehaviour
{
    [SerializeField]
    private GameObject people;

    [SerializeField]
    private GameObject car;

    [SerializeField]
    private GameObject motor;

    // public bool b_appear;
    // public bool b_disappear;
    public static int click;

    // Start is called before the first frame update
    void Start()
    {
        click = 0; //接playerpref的值
    }

    // Update is called once per frame
    void Update()
    {
        if (click == 1 || click == 0)
        {
            people.SetActive(true);
            car.SetActive(false);
            motor.SetActive(false);
            // click = false;
        }
        else if (click == 2)
        {
            people.SetActive(false);
            car.SetActive(true);
            motor.SetActive(false);
            // click = false;
        }
        else if (click == 3)
        {
            people.SetActive(false);
            car.SetActive(false);
            motor.SetActive(true);
            // click = false;
        }
        // b_notification_on();
    }

    public void click_people()
    {
        click = 1;
        // return;
    }

    public void click_car()
    {
        click = 2;
        // return;
    }

    public void click_motor()
    {
        click = 3;
        // return;
    }

    // void b_notification_on()
    // {
    //     // test2 = false;
    //     // notification.SetActive(true);
    //     if (b_appear == true)
    //     {
    //         people_appear = false;

    //     }
    //     else
    //     {
    //         people_appear = true;
    //         b_appear_notice.SetActive(false);
    //         b_disappear_notice.SetActive(true);
    //     }
    //     people_appear = true;
    //     // b_appear = false;
    //     // b_disappear = false;
    // }
}
