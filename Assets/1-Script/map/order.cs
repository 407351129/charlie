using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class order : MonoBehaviour
{
    public Text food_chinese_UI;

    [SerializeField]
    string[] food_speak;

    [SerializeField]
    private int now_food;

    [SerializeField]
    private int food_num;

    public GameObject get;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        now_food = Map_food.now_food;
        food_speak = levelstars.foods;

        food_chinese_UI.text = food_speak[food_num] + "";

        if (now_food > food_num)
        {
            get.SetActive(true);
        }

        // food_UI.text = food_speak[now_food] + "";
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class food_text : MonoBehaviour
// {

// }
