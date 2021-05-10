using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class practice : MonoBehaviour
{

    public Text food_chinese_UI;
    public Text correct_UI;
    public static bool correct;

    [SerializeField]
    string[] food_speak;

    [SerializeField]
    private int now_food_num;
    public static int now_food;

    public bool click;


    // Start is called before the first frame update
    void Start()
    {
    }


    public void get()
    {
        now_food = now_food_num;
        correct = false;
        correct_UI.text = "WRONG";
    }

    // Update is called once per frame
    void Update()
    {
        food_speak = levelstars.foods;

        if (AzureSpeech.message.Contains(food_speak[now_food]) == true)
        {
            correct = true;
            correct_UI.text = "CORRECT";
        }
        else
        {
            correct_UI.text = "WRONG";

        }
        food_chinese_UI.text = food_speak[now_food_num] + "";

    }
}
