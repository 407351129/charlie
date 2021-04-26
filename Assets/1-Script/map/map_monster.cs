using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map_monster : MonoBehaviour
{
    // public bool map_to_fight;
    // public bool end_map;
    [SerializeField]
    GameObject monster1;

    [SerializeField]
    GameObject monster2;

    [SerializeField]
    GameObject monster3;

    // public int test;
    [SerializeField]
    bool monster_alive;

    [SerializeField]
    bool monster1_alive;

    [SerializeField]
    bool monster2_alive;

    [SerializeField]
    bool monster3_alive;

    [SerializeField]
    private int map_fight_index;

    void Update()
    {
        map_fight_index = SceneManager.GetActiveScene().buildIndex;

        // monster_alive = BattleSystem.monster_alive;
        // monster1 = GameObject.Find("monster1");
        // monster2 = GameObject.Find("monster2");
        // monster3 = GameObject.Find("monster3");
        // test = monster_mapwalk.which_monster;
        if (map_fight_index == 2)
        {
            monster1_alive = true;
            monster2_alive = true;
            monster3_alive = true;
        }

        if (Map_time.map_start == true)
        {
            monster1 = GameObject.Find("monster1");
            monster2 = GameObject.Find("monster2");
            monster3 = GameObject.Find("monster3");
        }

        if (
            monster_mapwalk.which_monster == 1 &&
            BattleSystem.monster_alive == false
        )
        {
            // monster1.SetActive(false);
            monster1_alive = false;
        }
        else if (
            monster_mapwalk.which_monster == 2 &&
            BattleSystem.monster_alive == false
        )
        {
            // monster2.SetActive(false);
            monster2_alive = false;
        }
        else if (
            monster_mapwalk.which_monster == 3 &&
            BattleSystem.monster_alive == false
        )
        {
            // monster3.SetActive(false);
            monster3_alive = false;
        }

        // map_fight_index = SceneManager.GetActiveScene().buildIndex;
        monster1.SetActive (monster1_alive);
        monster2.SetActive (monster2_alive);
        monster3.SetActive (monster3_alive);
    }
}
// [SerializeField]
// private bool end_map; //之後接值
// void Awake()
// {
// GameObject map_monster = GameObject.Find("map_monster");
// monster1 = GameObject.Find("monster1");
// monster2 = GameObject.Find("monster2");
// monster3 = GameObject.Find("monster3");
// map_fight_index = SceneManager.GetActiveScene().buildIndex;
// if (map_fight_index == 2)
// {
//     monster1_alive = true;
//     monster2_alive = true;
//     monster3_alive = true;
// }
// if (
//     map_fight_index == 8 ||
//     map_fight_index == 3 ||
//     map_fight_index == 4 ||
//     map_fight_index == 5 ||
//     map_fight_index == 2
// )
// {
//     // if (map_fight_index == 8)
//     // {
//     DontDestroyOnLoad (map_monster);
//     // DontDestroyOnLoad (master1);
//     // DontDestroyOnLoad (master2);
//     // DontDestroyOnLoad (master3);
// }
// else
// {
//     Destroy (map_monster);
//     // exit_map = true;
// }
// if (
//     monster_mapwalk.which_monster == 1 &&
//     BattleSystem.monster_alive == false
// )
// {
//     // monster1.SetActive(false);
//     monster1_alive = false;
// }
// if (
//     monster_mapwalk.which_monster == 2 &&
//     BattleSystem.monster_alive == false
// )
// {
//     // monster2.SetActive(false);
//     monster2_alive = false;
// }
// if (
//     monster_mapwalk.which_monster == 3 &&
//     BattleSystem.monster_alive == false
// )
// {
//     // monster3.SetActive(false);
//     monster3_alive = false;
// }
// }
// }
//     // Start is called before the first frame update
// void Start()
// {
//     monster1 = GameObject.Find("monster1");
//     monster2 = GameObject.Find("monster2");
//     monster3 = GameObject.Find("monster3");
// }
//     return;
//     if (end_map == true)
//     {
//         map_to_fight = false;
//     }
//     // else{
//     // }
//     if (
//         (map_to_fight == false && Map_time.map_start == true) ||
//         map_fight_index == 2
//     )
//     {
//         // map_to_fight = false;
//         monster1_alive = true;
//         monster2_alive = true;
//         monster3_alive = true;
//         monster1.SetActive (monster1_alive);
//         monster2.SetActive (monster2_alive);
//         monster3.SetActive (monster3_alive);
//         //顯示三隻怪物
//     }
//     // else
//     // // else if (map_to_fight == true)
//     // // else
//     // // {
//     // //     if (
//     // //         monster_mapwalk.which_monster == 1 &&
//     // //         BattleSystem.monster_alive == false
//     // //     )
//     // //     {
//     // //         monster1_alive = false;
//     // //     }
//     // //     if (
//     // //         monster_mapwalk.which_monster == 2 &&
//     // //         BattleSystem.monster_alive == false
//     // //     )
//     // //     {
//     // //         monster2_alive = false;
//     // //     }
//     // //     if (
//     // //         monster_mapwalk.which_monster == 3 &&
//     // //         BattleSystem.monster_alive == false
//     // //     )
//     // //     {
//     // //         monster3_alive = false;
//     // //     }
//     // // }
//     // {
//     //     if (
//     //         monster_mapwalk.which_monster == 1 &&
//     //         BattleSystem.monster_alive == false
//     //     )
//     //     {
//     //         monster1.SetActive(false);
//     //         monster1_alive = false;
//     //     }
//     //     if (
//     //         monster_mapwalk.which_monster == 2 &&
//     //         BattleSystem.monster_alive == false
//     //     )
//     //     {
//     //         monster2.SetActive(false);
//     //         monster2_alive = false;
//     //     }
//     //     if (
//     //         monster_mapwalk.which_monster == 3 &&
//     //         BattleSystem.monster_alive == false
//     //     )
//     //     {
//     //         monster3.SetActive(false);
//     //         monster3_alive = false;
//     //     }
//     // }
//     // test = GameManager.hi;
//     // map = GameObject.Find("Player").GetComponent<people_map>();
// }
//     // Update is called once per frame
