using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_food : MonoBehaviour
{
    public int get_food;

    // [SerializeField]
    // GameObject[] food;
    // [SerializeField]
    // GameObject[] map_pin;
    [SerializeField]
    GameObject[] map_pin;

    [SerializeField]
    GameObject parent_map_pin;

    [SerializeField]
    string[] food_speak;

    private int now_food;

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
        now_food = 0;
    }

    // Update is called once per frame
    void Update()
    {
        map_pin = new GameObject[4];

        parent_map_pin = GameObject.Find("map_pin");
        for (int i = 0; i < 4; i++)
        {
            map_pin[i] = parent_map_pin.transform.GetChild(i).gameObject;
        }

        // food = GameObject.FindGameObjectsWithTag("Food");
        // map_pin = GameObject.FindGameObjectsWithTag("Food");
        if (AzureSpeech.message.Contains(food_speak[0]) == true)
        {
            // map_pin[1].SetActive(false);
        }
        // for (int i = 1; i <= 4; i++)
        // {
        // GameObject[] myObjArray;
        // }
        // if()
    }
}
