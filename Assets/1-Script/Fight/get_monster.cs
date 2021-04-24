using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class get_monster : MonoBehaviour
{
    public int monster;

    [SerializeField]
    int map_fight_index;

    GameObject monster1;

    GameObject monster2;

    GameObject monster3;

    [SerializeField] bool monster_alive;

    // Image get_monster_img;
    // Start is called before the first frame update
    void Awake()
    {
        monster = people_map.which_monster;

        // GameObject[] objs = GameObject.FindGameObjectsWithTag("Monster");
        // if(people_map.fight_notice == true){
        monster1 = GameObject.Find("monster1");
        monster2 = GameObject.Find("monster2");
        monster3 = GameObject.Find("monster3");

        // if (
        //     people_map.which_monster == 0 //
        // )
        // {
        // }
        map_fight_index = SceneManager.GetActiveScene().buildIndex;

        // if (map_fight_index == 8)
        // {
        if (monster <= 0)
        {
            Destroy(this.gameObject);
        }

        if (people_map.which_monster == 1)
        {
            DontDestroyOnLoad (monster1);
            Destroy (monster2);
            Destroy (monster3);
        }
        else if (people_map.which_monster == 2)
        {
            DontDestroyOnLoad (monster2);
            Destroy (monster1);
            Destroy (monster3);
        }
        else if (people_map.which_monster == 3)
        {
            DontDestroyOnLoad (monster3);
            Destroy (monster1);
            Destroy (monster2);
        }
        // }
        // else
        // {
        //     Destroy (monster1);
        //     Destroy (monster2);
        //     Destroy (monster3);
        // }
        // int map_fight_index = SceneManager.GetActiveScene().buildIndex;
        // if (map_fight_index == 3 || map_fight_index == 4 || map_fight_index == 5
        // )
        // {
        //     Destroy (monster1);
        //     Destroy (monster2);
        //     Destroy (monster3);
        // }
        // else
        // {
    }

    void Update()
    {
        monster_alive = BattleSystem.monster_alive;
        map_fight_index = SceneManager.GetActiveScene().buildIndex;

        if (map_fight_index != 8)
        {
            // if(people_map.which_monster == 1 &&)
            Destroy (monster1);
            Destroy (monster2);
            Destroy (monster3);
        }
    }
    // }
    //     void Start()
    //     {
    //         GameObject box;
    // 　　　Rigidbody box_rb;
    // 　　　void Start () {
    // 　　　　　box = GameObject.Find("PackForest01.png");
    // 　　　　　box_rb = box.GetComponent<Rigidbody>();
    // 　　　}
    // monster = people_map.which_monster;
    // GameObject prueba = new GameObject("prueba");
    // SpriteRenderer renderer = prueba.AddComponent<SpriteRenderer>();
    // // Sprite [] sprites
    // Object [] sprites =
    //     Resources
    //         .LoadAll("Assets/2-Character/test/Assets/Textures/PackForest01");

    // // monster = people_map.which_monster;
    // // get_monster_img =
    // //         Resources
    // //             .Load("Assets/2-Character/test/Assets/PackForest01.png")
    // if (people_map.which_monster == 1)
    // {
    //     renderer.sprite = (Sprite) sprites [1];
    //     // get_monster_img = (Sprite) sprites [1];
    // }
    // else if (people_map.which_monster == 2)
    // {
    //     renderer.sprite = (Sprite) sprites [1];
    //     // get_monster_img = (Sprite) sprites [1];

    // }
    // else if (people_map.which_monster == 3)
    // {
    //     renderer.sprite = (Sprite) sprites [1];
    //     // get_monster_img = (Sprite) sprites [1];
    // }
    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
