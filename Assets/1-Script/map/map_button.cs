using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_button : MonoBehaviour
{
    public static int leftorright;

    public static bool left_is_press;

    public static bool walk_is_press;

    public static bool right_is_press;

    public int l;

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
        left_on();
        walk_on();
        right_on();
    }

    public void leftbutton_click()
    {
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
        if (left_is_press == true)
        {
            leftorright = 1;
            return;
        }
    }

    void walk_on()
    {
        if (walk_is_press == true)
        {
            leftorright = 2;
            return;
        }
    }

    void right_on()
    {
        if (right_is_press == true)
        {
            leftorright = 3;
            return;
        }
    }
}
