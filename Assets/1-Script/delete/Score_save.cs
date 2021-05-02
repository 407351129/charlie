using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score_save : MonoBehaviour
{

    public GameObject score;
 


    void AddScore(float score) //分數增加
    {
        if (PlayerPrefs.HasKey("Player Score"))//若playerpref檢查資料庫內有player score
        {
            float oldScore = PlayerPrefs.GetFloat("Player Score"); //獲取資料庫內的playerscore
            PlayerPrefs.SetFloat("Player Score", oldScore + score);//若資料庫內沒有分數 設為0
        }
        else PlayerPrefs.SetFloat("Player Score", 0);//若資料庫內沒有分數 設為0
    }

    void SubtractScore(float score) //分數減少
    {
        if (PlayerPrefs.HasKey("Player Score"))
        {
            float oldScore = PlayerPrefs.GetFloat("Player Score");
            if ((oldScore - score) < 0)
                PlayerPrefs.SetFloat("Player Score", 0);
            else
                PlayerPrefs.SetFloat("Player Score", oldScore - score);
        }
        else PlayerPrefs.SetFloat("Player Score", 0);
    }

    void StoreHighscore(int newHighscore) //設最高分數
    {
        int oldHighscore = PlayerPrefs.GetInt("highscore", 0);
        if (newHighscore > oldHighscore)
            PlayerPrefs.SetInt("highscore", newHighscore);
    }
}
