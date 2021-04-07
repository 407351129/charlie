using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_map : MonoBehaviour
{
    private int leftorright;

    // private bool left_is_press;
    // private bool walk_is_press;
    // private bool right_is_press;
    public GameObject people;

    Transform Player;

    public Animator Action_Controller;

    public bool left;

    public bool right;

    public bool at_corner;

    // public bool over;
    // public int anim_num;
    // public bool left;
    // Transform Player;
    public float MoveSpeed;

    public bool wall;

    public int transportation; //之後用private, 另一個頁面用static

    public int corner_num;

    // public static int myState;
    // public int test;
    public bool move_map;

    // public int num;
    public int temp_corner_num;

    // public int ii;
    public bool turn_back;

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
        Action_Controller.SetBool("left", left);
        Action_Controller.SetBool("right", right);

        // Action_Controller.SetBool("at_corner", at_corner);
        Action_Controller.SetBool("move_map", move_map);
        turn_direction();
        walk();
        // OnCollisionEnter2D(gameObject.tag);
    }

    public void turn_direction()
    {
        // AnimatorStateInfo currentState =
        //     Action_Controller.GetCurrentAnimatorStateInfo(0);
        leftorright = map_button.leftorright;

        // test = leftorright;
        if (leftorright != 0 && wall == false)
        {
            MoveSpeed = 1f + transportation * 0.15f; //暫時調快 原先0.2
        }
        if (at_corner == true && wall == false)
        {
            MoveSpeed = 0.2f;

            // else
            // {
            //     MoveSpeed = 0;
            // }
            if (wall == false)
            {
                // if (at_corner == true)
                // {
                // MoveSpeed = 0.2f;
                if (leftorright == 1)
                {
                    // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
                    left = true;
                    right = false;
                    // dont_trun();

                    // Action_Controller.SetBool("at_corner", false);
                    // Player.Translate(0, MoveSpeed * Time.deltaTime, 0); //背影
                }
                else if (leftorright == 2)
                {
                    left = false;
                    right = false;
                    //正面
                    // Player.Translate(MoveSpeed * Time.deltaTime,0 , 0); //朝右
                    // Player.Translate(-MoveSpeed * Time.deltaTime,0 , 0); //朝左
                }
                else if (leftorright == 3)
                {
                    left = false;
                    right = true;
                    // if (Animator.GetCurrentAnimatorStateInfo(0).IsName("Over"))
                    // {
                    //     at_corner = false;
                    // }
                }
                else
                {
                    left = false;
                    right = false;
                }
                // }
            }
            // else if (wall == true && leftorright != 2 && MoveSpeed == 0)
            // {
            //     // MoveSpeed = 0.2f + transportation * 0.15f; //暫時調快 原先0.2
            // }
            // anim_num = 1;
            // }
            // }
            // else
            // {
            //     return leftorright;
            // }
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

    // if (corner_num % 2 == 0)
    //                     {
    //                         move_map = true;
    //                         Action_Controller.SetBool("move_map", move_map);
    //                         return;
    //                         // move_map = false;
    //                         // Action_Controller.SetBool("move_map", move_map);
    //                         // Action_Controller.SetInt("move", 1);
    //                         // at_corner = true;
    //                         // Action_Controller.SetInt("move", move);
    //                         // wall = false;
    //                         // wall_times++;
    //                     }
    //                     else if (corner_num % 2 == 1)
    //                     {
    //                         // at_corner = true;
    //                         move_map = false;
    //                         Action_Controller.SetBool("move_map", move_map);
    //                         // move_map = true;
    //                         // Action_Controller.SetBool("move_map", move_map);
    //                         // Action_Controller.SetInt("move", 2);
    //                         // Action_Controller.SetInt("move", move);
    //                         // wall = false;
    //                         // wall_times++;
    //                         return;
    //                     }
    //                     corner_num++;
    // }
    // }
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
                    // Action_Controller.SetInt("move", 1);

                    // at_corner = true;
                    // Action_Controller.SetInt("move", move);
                }
                else if (corner_num % 2 == 1)
                {
                    // at_corner = true;
                    move_map = false;
                    Action_Controller.SetBool("move_map", move_map);

                    // Action_Controller.SetInt("move", 2);

                    // Action_Controller.SetInt("move", move);
                }
                temp_corner_num = corner_num;
                corner_num++;
                return;
            }
        }

        // at_corner = true;
        // AnimatorStateInfo now_anim =
        //     Action_Controller.GetCurrentAnimatorStateInfo(0).IsName();
        // now_anim = next_anim.IsName();
        // }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Floor")
        {
            at_corner = false;
            Action_Controller.SetBool("at_corner", at_corner);

            // test = 0;
        }
        // if (c.gameObject.tag == "Wall")
        // {
        //     wall = true;
        //     trurn_back();
        // }
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
    }

    // void people_wall{
    // }
    void people_turn_back()
    {
        AnimatorStateInfo turnback =
            Action_Controller.GetCurrentAnimatorStateInfo(0);

        // AnimatorStateInfo turnback =
        //             Action_Controller.GetCurrentAnimatorStateInfo(0);
        // Player.eulerAngles = new Vector3(0, 0, 0);
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
