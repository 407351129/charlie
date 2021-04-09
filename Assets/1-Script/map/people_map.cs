using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_map : MonoBehaviour
{
    private int leftorright;

    public static GameObject people;

    Transform Player;

    public Animator Action_Controller;

    public bool left;

    public bool right;

    public bool at_corner;

    public float MoveSpeed;

    public bool wall;

    public int transportation; //之後用private, 另一個頁面用static

    public int corner_num;

    public bool move_map;

    public int temp_corner_num;

    public bool turn_back;

    public static bool fight_notice;

    public static bool appear;

    public static bool disappear;

    public bool aaaa;

    // public bool ddd;
    void Start()
    {
        transportation = 3; //之後接值替換
        MoveSpeed = 0;
        move_map = false;
        turn_back = false;
        at_corner = false;

        people = gameObject;
        Player = gameObject.transform;
        Action_Controller = people.GetComponent<Animator>();
    }

    void Update()
    {
        aaaa = fight_notice;

        // ddd = disappear;
        Action_Controller.SetBool("left", left);
        Action_Controller.SetBool("right", right);

        Action_Controller.SetBool("move_map", move_map);
        turn_direction();
        walk();
    }

    public void turn_direction()
    {
        leftorright = map_button.leftorright;

        if (leftorright != 0 && wall == false)
        {
            MoveSpeed = 1f + transportation * 0.15f; //暫時調快 原先0.2
        }
        if (at_corner == true && wall == false)
        {
            MoveSpeed = 0.2f;

            if (wall == false)
            {
                if (leftorright == 1)
                {
                    left = true;
                    right = false;
                }
                else if (leftorright == 2)
                {
                    left = false;
                    right = false;
                }
                else if (leftorright == 3)
                {
                    left = false;
                    right = true;
                }
                else
                {
                    left = false;
                    right = false;
                }
            }
        }
    }

    void walk()
    {
        // if (leftorright == 2)
        // {
        AnimatorStateInfo currentState =
            Action_Controller.GetCurrentAnimatorStateInfo(0);
        Player.eulerAngles = new Vector3(0, 0, 0);

        if (wall == false)
        {
            if (
                currentState.nameHash ==
                Animator.StringToHash("Base Layer.people_walk")
            )
            // leftorright == 1
            {
                Player.Translate(0, -MoveSpeed * Time.deltaTime, 0);
            }
            else if (
                currentState.nameHash ==
                Animator.StringToHash("Base Layer.people_left")
            )
            {
                Player.Translate(-MoveSpeed * Time.deltaTime, 0, 0); //朝左
            }
            else if (
                currentState.nameHash ==
                Animator.StringToHash("Base Layer.people_right")
            )
            {
                Player.Translate(MoveSpeed * Time.deltaTime, 0, 0); //朝右
            }
            else if (
                currentState.nameHash ==
                Animator.StringToHash("Base Layer.people_back")
            )
            {
                Player.Translate(0, MoveSpeed * Time.deltaTime, 0); //背影
            }
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        // test = 100;
        if (c.gameObject.tag == "Floor")
        {
            at_corner = true;
            Action_Controller.SetBool("at_corner", at_corner);
            if (leftorright == 1 || leftorright == 3)
            {
                if (corner_num % 2 == 0)
                {
                    move_map = true;
                    Action_Controller.SetBool("move_map", move_map);
                }
                else if (corner_num % 2 == 1)
                {
                    // at_corner = true;
                    move_map = false;
                    Action_Controller.SetBool("move_map", move_map);
                }
                temp_corner_num = corner_num;
                corner_num++;
                return;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Floor")
        {
            at_corner = false;
            Action_Controller.SetBool("at_corner", at_corner);
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Wall")
        {
            // MoveSpeed = 0;
            wall = true;
            if (leftorright != 0)
            {
                if (turn_back == false)
                {
                    MoveSpeed = 0;
                    wall = true;
                    people_turn_back();

                    // wall = false;
                    if (turn_back == true)
                    {
                        wall = false;
                        turn_back = false;
                        turn_direction();
                    }
                }
            }
        }
        if (c.gameObject.tag == "Monster")
        {
            fight_notice = true;
            // appear_2notification.appear_on();

            // // appear_on ap = new appear_on();fight_notice, fight_notice
            // appear_2notification.notification_on();
            // appear_2notification.appear_on(true, true);
        }
    }

    // void people_wall{
    // }
    void people_turn_back()
    {
        AnimatorStateInfo turnback =
            Action_Controller.GetCurrentAnimatorStateInfo(0);

        if (wall == true)
        {
            if (
                turnback.nameHash ==
                Animator.StringToHash("Base Layer.people_walk")
            )
            // leftorright == 1
            {
                Action_Controller.Play("Base Layer.people_back", 0, 0);
                turn_back = true;
            }
            else if (
                turnback.nameHash ==
                Animator.StringToHash("Base Layer.people_left")
            )
            {
                Action_Controller.Play("Base Layer.people_right", 0, 0);
                turn_back = true;
            }
            else if (
                turnback.nameHash ==
                Animator.StringToHash("Base Layer.people_right")
            )
            {
                Action_Controller.Play("Base Layer.people_left", 0, 0);
                turn_back = true;
            }
            else if (
                turnback.nameHash ==
                Animator.StringToHash("Base Layer.people_back")
            )
            {
                Action_Controller.Play("Base Layer.people_walk", 0, 0);
                turn_back = true;
            }
            // wall = false;
        }

        // }
    }
}
