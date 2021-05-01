using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorLevel : MonoBehaviour
{
    public int level_int = 1;
    public string level_string;
    public Text levelText;
    //private int n = 4;
    //public bool click;

    //void Start()
    //{
    //    click = false;
    //}

    //private void Awake()
    //{
    //    DontDestroyOnLoad(this.gameObject);
    //}

    public void SetLevel()
    {
        //click = true;
        level_int++;
        if (level_int == 1) level_string = "1";
        else if (level_int == 2) level_string = "2";
        else if (level_int == 3) level_string = "3";

        levelText.text = level_string;
    }
}
