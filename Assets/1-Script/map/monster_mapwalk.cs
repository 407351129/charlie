using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_mapwalk : MonoBehaviour
{
    // private GameObject people;
    // RectTransform monster_img = GetComponent<RectTransform>();
    Transform monster_img;

    public bool m_wall;

    public bool m_turn;

    public int m_walk_num;

    [SerializeField]
    private int map_which_monster; //不能刪[SerializeField]

    public static int which_monster;

    public int test_which_monster;

    // public int which_monster;
    // public int monster_num;
    // public bool m_test;
    // Start is called before the first frame update
    void Start()
    {
        which_monster = 0;

        monster_img = gameObject.transform;

        // if (
        //     monster_mapwalk.which_monster == which_monster &&
        //     BattleSystem.monster_alive == false
        // )
        // {
        //     monster_alive = false;
        //     // this.SetActive(false);
        //     // monster1_alive = false;
        // }
        // if (
        //     monster_mapwalk.which_monster == which_monster &&
        //     BattleSystem.monster_alive == false
        // )
        // {
        //     monster_alive = false;

        //     // this.SetActive(false);
        //     // monster2_alive = false;
        // }
        // if (
        //     monster_mapwalk.which_monster == which_monster &&
        //     BattleSystem.monster_alive == false
        // )
        // {
        //     monster_alive = false;

        //     // this.SetActive(false);
        //     // monster3_alive = false;
        // }
        // which_monster = 0;

        // var pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        test_which_monster = which_monster;
        m_walk();
    }

    void m_walk()
    {
        // if(m_turn == true){
        // }
        if (m_wall == false)
        {
            m_turn = false;
            if (m_walk_num % 2 == 0)
            {
                transform.position =
                    new Vector3(transform.position.x - 0.4f * Time.deltaTime,
                        transform.position.y,
                        transform.position.z); //0.4
            }
            else if (m_walk_num % 2 == 1)
            {
                transform.position =
                    new Vector3(transform.position.x + 0.4f * Time.deltaTime,
                        transform.position.y,
                        transform.position.z);
            }
        }
    }

    void m_turn_d()
    {
        if (m_walk_num % 2 == 0)
        {
            monster_img.localEulerAngles = new Vector3(0, 0, 0);
            m_turn = true;
        }
        else
        {
            monster_img.localEulerAngles = new Vector3(0, -180, 0);
            m_turn = true;
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Wall")
        {
            m_wall = true;
            m_walk_num++;
            m_turn_d();
            if (m_turn == true)
            {
                m_wall = false;
            }
            // m_wall = false;
            // return;
        }

        if (c.gameObject.tag == "Player")
        {
            // Player.Translate(300, 4000, 0);
            // fight_notice = true;
            which_monster = map_which_monster;

            // if (c.gameObject.name == "monster1")
            // {
            //     which_monster = 1;
            // }
            // else if (c.gameObject.name == "monster2")
            // {
            //     which_monster = 2;
            // }
            // else if (c.gameObject.name == "monster3")
            // {
            //     which_monster = 3;
            // }

            // public int which_monster;

            // appear_2notification.appear_on();

            // // appear_on ap = new appear_on();fight_notice, fight_notice
            // appear_2notification.notification_on();
            // appear_2notification.appear_on(true, true);
        }
    }

    // void OnCollisionEnter2D(Collision2D c)
    // {

    // }
    // void return_monster_name(){

    //     if(GetComponent())
    // }
    // Vector3 Pos = gameObject.transform.position;
    // Vector3 pos = gameObject.transform.localPosition;
    // A++;
    // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
    // if(posx == -336){
    //                 A++;
    //                 }
    // if (pos.x > -336 && A % 2 == 1){
    //             // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
    //             // A = A - 2 * monster + 7;
    //             transform.position = new Vector3 (Mathf.Clamp(transform.position.x + 1f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
    //         }
    //         else{
    //             transform.position = new Vector3 (Mathf.Clamp(transform.position.x - 1f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
    //         }
    // var pos = gameObject.transform.position;
    // posx = pos.x;
    // if (posx == -3)
    // {
    //     A++;
    // }
    // else if (posx == 3)
    // {
    //     A++;
    // }

    // if (pos.x <= 327 && A % 2 == 1)
    // {
    //     // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
    //     // A = A - 2 * monster + 7;
    //     transform.position =
    //         new Vector3(Mathf
    //                 .Clamp(transform.position.x - 0.5f * Time.deltaTime,
    //                 minPosX,
    //                 maxPosX),
    //             transform.position.y,
    //             transform.position.z);

    //     monster_img.localEulerAngles = new Vector3(0, 0, 0);
    // }
    // else
    // {
    //     transform.position =
    //         new Vector3(Mathf
    //                 .Clamp(transform.position.x + 0.5f * Time.deltaTime,
    //                 minPosX,
    //                 maxPosX),
    //             transform.position.y,
    //             transform.position.z);
    //     monster_img.localEulerAngles = new Vector3(0, -180, 0);
    // }

    // var pos = transform.position;
    // posx = pos.x;
    // if(posx == -3){
    //                 A++;
    //                 }else if(posx == 3){
    //                     A++;
    //                 }

    //         if (pos.x <= 3 && A % 2 == 1){

    //             // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
    //             // A = A - 2 * monster + 7;

    //             transform.position = new Vector3 (Mathf.Clamp(transform.position.x - 2f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);

    //         }
    //         else{
    //             transform.position = new Vector3 (Mathf.Clamp(transform.position.x + 2f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
    //         }

    // if (A < 150){
    //     A = A - 2 * monster + 7;
    //     transform.position = new Vector3 (Mathf.Clamp(transform.position.x + 5f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
    // }
    // else if (A < 300){
    //     // transform.Translate(new Vector2(3, 0) * Time.deltaTime);
    //     transform.position = new Vector3 (Mathf.Clamp(transform.position.x - 5f * Time .deltaTime, minPosX, maxPosX), transform.position.y, transform.position.z);
    // }
    // else{
    //     A = monster;
    // }

    //         A++;
    //         if (A<200)
    // {
    //     transform.Translate(new Vector2(1, 0) * Time.deltaTime);
    //        //当达到最右边时的最远距离
    // //             transform.position = new Vector3 (transform.position.x + 3f * Time .deltaTime, transform.position.y, 0);
    //         }

    //         // 当达到最右边时的最远距离并且回到原点时
    //         if (A>200&&A<400)
    //         {
    //            transform.position = new Vector3 (transform.position.x - 3f * Time .deltaTime, transform.position.y, 0);
    //         }
    //         if (A>400)
    //         {
    //          //原点继续出去
    //             A = 0;
    //         }
}
