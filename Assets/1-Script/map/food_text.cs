using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class food_text : MonoBehaviour
{
    public Text food_chinese_UI;

    [SerializeField]
    string[] food_speak;

    [SerializeField]
    private int now_food;

    public GameObject map_pin_end;

    // Start is called before the first frame update
    // void Start()
    // {
    // }
    // Update is called once per frame
    void Update()
    {
        now_food = Map_food.now_food;
        food_speak = levelstars.foods;

        food_chinese_UI.text = food_speak[now_food] + "";

        if (now_food == 3)
        {
            map_pin_end.SetActive(true);
        }
        else
        {
            map_pin_end.SetActive(false);
        }
        // food_UI.text = food_speak[now_food] + "";
    }
}
