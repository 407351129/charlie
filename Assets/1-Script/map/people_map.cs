using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_map : MonoBehaviour
{
    public static int which_monster;

    private int leftorright;

    public static GameObject people;

    public GameObject map;

    public GameObject map_monster;

    // public GameObject monster;
    Transform Player;

    public Animator Action_Controller;

    public bool left;

    public bool right;

    public bool at_corner;

    public float MoveSpeed;

    public bool wall;

    public int transportation; //之後用private, 另一個頁面用static

    public bool turn_back;

    public static bool fight_notice;

    public bool move_map;

    private int corner_num;

    private int temp_corner_num;

    // public bool people_appear;
    // public int appear_num;
    // public int temp_appear_num;
    public float x;

    public float y;

    // public static bool appear;
    // public static bool disappear;
    // public bool aaaa;
    // public bool ddd;
    void Start()
    {
        transportation = 3; //之後接值替換
        MoveSpeed = 0;
        move_map = false;
        turn_back = false;
        at_corner = false;

        // people_appear = true;
        // appear_num = 0;
        // temp_appear_num = 0;
        people = gameObject;
        Player = gameObject.transform;
        Action_Controller = people.GetComponent<Animator>();
    }

    void Update()
    {
        // aaaa = fight_notice;
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
            MoveSpeed = 0.3f;

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

        if (
            wall == false &&
            map.activeInHierarchy == true &&
            map_monster.activeInHierarchy == true
        )
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
            x = Player.transform.position.x;
            y = Player.transform.position.y;
        }
    }

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

    // void people_on_map()
    // {
    //     if (map.activeInHierarchy == true)
    //     {
    //         Player.Translate(300, 1800, 0);
    //     }
    //     else
    //     {
    //         Player.Translate(x, y, 0);
    //     }
    // }
    void OnTriggerExit2D(Collider2D c)
    {
        // if (c.gameObject.tag == "Appear")
        // {
        //     MoveSpeed = 0;
        // }
        // test = 100;
        if (c.gameObject.tag == "Floor")
        {
            if (b_appear_2notification.people_appear == true)
            {
                at_corner = true;
                Action_Controller.SetBool("at_corner", at_corner);
            }
            else if (b_appear_2notification.people_appear == false)
            {
                at_corner = false;
            }
            if (leftorright == 1 || leftorright == 3)
            {
                if (
                    map.activeInHierarchy == true &&
                    map_monster.activeInHierarchy == true
                )
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
            Player.Translate(300, 4000, 0);
            fight_notice = true;

            if (c.gameObject.name == "monster1")
            {
                which_monster = 1;
            }
            else if (c.gameObject.name == "monster2")
            {
                which_monster = 2;
            }
            else if (c.gameObject.name == "monster3")
            {
                which_monster = 3;
            }

            // public int which_monster;

            // appear_2notification.appear_on();

            // // appear_on ap = new appear_on();fight_notice, fight_notice
            // appear_2notification.notification_on();
            // appear_2notification.appear_on(true, true);
        }
    }

    // void people_wall{
    // }
}
