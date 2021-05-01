using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map_food : MonoBehaviour
{
    public static bool get_food;

    public bool test_get_food;

    // [SerializeField]
    // GameObject[] food;
    // [SerializeField]
    // GameObject[] map_pin;
    [SerializeField]
    GameObject[] map_pin;

    [SerializeField]
    GameObject parent_map_pin;

    [SerializeField]
    string[] food_speak; //接關卡資料庫的

    [SerializeField]
    bool[] map_pin_appear;

    [SerializeField]
    private int now_food;

    [SerializeField]
    private int which_map_pin;

    [SerializeField]
    private int map_fight_index;

    [SerializeField]
    private int now_level;

    [SerializeField]
    private bool speak_get_food;

    // [SerializeField]
    // private int test_i;
    // [SerializeField]
    // GameObject map_pin2;
    // [SerializeField]
    // GameObject map_pin3;
    // [SerializeField]
    // GameObject map_pin4;
    // [SerializeField]
    // int pin_num;
    // Start is called before the first frame update
    void Start()
    {
        //         food_speak = new string[4];　// 定義陣列長度(同時會清空陣列)
        // food_speak = new string[] { "hello", "world", "game", "learning", "unity" };　// 定義陣列的值和長度
        food_speak = new string[] { "珍珠奶茶", "牛肉", "豬肉" };
        map_pin = new GameObject[4];
        map_pin_appear = new bool[4];
        now_food = 0;

        map_pin_appear[0] = true;
        map_pin_appear[1] = true;
        map_pin_appear[2] = true;
        map_pin_appear[3] = true;
    }

    // Update is called once per frame
    void Update()
    {
        now_level = levelstars.now_level;
        test_get_food = get_food;
        speak_get_food = b_appear_2notification.speak_get_food;
        map_fight_index = SceneManager.GetActiveScene().buildIndex;

        which_map_pin = appear_2notification.which_map_pin;
        map_pin = new GameObject[4];

        parent_map_pin = GameObject.Find("map_pin");

        if (map_fight_index == 2)
        {
            map_pin_appear[0] = true;
            map_pin_appear[1] = true;
            map_pin_appear[2] = true;
            map_pin_appear[3] = true;
        }
        for (int i = 1; i < 5; i++)
        {
            if (map_fight_index == 2)
            {
                map_pin_appear[i] = true;
                now_food = 0;
                // test_i = i;
            }
            map_pin[i - 1] =
                parent_map_pin.transform.GetChild(i - 1).gameObject;
            if (
                i == which_map_pin &&
                map_fight_index != 2 &&
                AzureSpeech.message.Contains(food_speak[now_food]) == true &&
                speak_get_food == false
            )
            // food_notice
            {
                map_pin_appear[i - 1] = false;
                now_food++;
                get_food = true;
                map_pin[i - 1].SetActive(map_pin_appear[i - 1]);
            }
        }
        // if (speak_get_food == false && get_food == true)
        // {
        //     get_food = false;
        // }

        // food = GameObject.FindGameObjectsWithTag("Food");
        // map_pin = GameObject.FindGameObjectsWithTag("Food");
        // if (AzureSpeech.message.Contains(food_speak[0]) == true)
        // {
        //     // map_pin[1].SetActive(false);
        // }
        // for (int i = 1; i <= 4; i++)
        // {
        // GameObject[] myObjArray;
        // }
        // if()
    }
}
