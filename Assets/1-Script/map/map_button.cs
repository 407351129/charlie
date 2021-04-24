using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_button : MonoBehaviour
{
    public static int leftorright;

    public static bool left_is_press;

    public static bool walk_is_press;

    public static bool right_is_press;

    // public bool Contains (string value);
    // public static string s2;
    // public bool b;
    public int l;

    public int stop_talk;

    // public int test_stop_talk;
    public GameObject walk_button;

    // Start is called before the first frame update
    void Start()
    {
        walk_button = gameObject;
        leftorright = 0;
        left_is_press = false;
        walk_is_press = false;
        right_is_press = false;
    }

    // Update is called once per frame
    void Update()
    {
        // test_stop_talk=stop_talk;
        // b = AzureSpeech.message.Contains(s2);
        left_on();
        walk_on();
        right_on();
    }

    public void leftbutton_click()
    {
        // InvokeRepeating("timer", 1, 1);
        left_is_press = true;
        walk_is_press = false;
        right_is_press = false;

        // leftorright = 1;
        // l = 1;
        return;
    }

    public void walkbutton_click()
    {
        left_is_press = false;
        walk_is_press = true;
        right_is_press = false;

        // leftorright = 2;
        // l = 23;
        return;
        // return leftorright;
    }

    public void rightbutton_click()
    {
        left_is_press = false;
        walk_is_press = false;
        right_is_press = true;

        // leftorright = 3;
        // l = 36;
        return;
        // return leftorright;
    }

    void left_on()
    {
        // stop_talk = 0;
        // InvokeRepeating("timer", 1, 1);
        // s2 = "左轉";
        if (AzureSpeech.message.Contains("左轉") == true)
        {
            if (left_is_press == true)
            {
                leftorright = 1;
                return;
            }
        }
    }

    void walk_on()
    {
        if (AzureSpeech.message.Contains("直走") == true)
        {
            if (walk_is_press == true)
            {
                leftorright = 2;
                return;
            }
        }
    }

    void right_on()
    {
        if (AzureSpeech.message.Contains("右轉") == true)
        {
            if (right_is_press == true)
            {
                leftorright = 3;
                return;
            }
        }
    }

    // void timer()
    // {
    //     stop_talk += 1;
    // }
}
