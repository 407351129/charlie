// using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using UnityEngine.UI;
public class button_attack : MonoBehaviour
{
    public static bool fight_on;

    private string chinese;

    public bool f_on;

    void Start()
    {
        // Button btn = this.GetComponent<Button>();
        // btn.onClick.AddListener (OnClick);
    }

    void Update()
    {
        chinese = questionData.Questions_Chinese; //接上資料庫的chinese
        if (
            countdown.time_out == true ||
            AzureSpeech.message.Contains(chinese) //再加上或語音(攻擊)成功
        )
        {
            fight_on = false;
        }
    }

    public void Fight_OnClick()
    {
        // Application.Quit();
        fight_on = true;
        //f_on = fight_on;

        // return;
    }
}
