using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapPage : MonoBehaviour
{
    public bool map_to_fight;

    public bool end_map;

    public GameObject master1;

    public GameObject master2;

    public GameObject master3;

    public int test;

    [SerializeField]
    bool monster_alive;

    // void Awake()
    // {
    // }
    //     // Start is called before the first frame update
    void Start()
    {
        if (end_map == true)
        {
            map_to_fight = false;
        }

        // else{
        // }
        if (map_to_fight == false)
        {
            master1.SetActive(true);
            master2.SetActive(true);
            master3.SetActive(true);
            //顯示三隻怪物
        }
        else
        {
            if (
                people_map.which_monster == 1 &&
                BattleSystem.monster_alive == false
            )
            {
                master1.SetActive(false);
            }
            if (
                people_map.which_monster == 2 &&
                BattleSystem.monster_alive == false
            )
            {
                master2.SetActive(false);
            }
            if (
                people_map.which_monster == 3 &&
                BattleSystem.monster_alive == false
            )
            {
                master3.SetActive(false);
            }
        }

        // test = GameManager.hi;
        // map = GameObject.Find("Player").GetComponent<people_map>();
    }

    //     // Update is called once per frame
    void Update()
    {
        monster_alive = BattleSystem.monster_alive;
    }
}
