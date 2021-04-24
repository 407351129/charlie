using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score_save : MonoBehaviour
{

    public GameObject score;
 


    void AddScore(float score)
    {
        if (PlayerPrefs.HasKey("Player Score"))
        {
            float oldScore = PlayerPrefs.GetFloat("Player Score");
            PlayerPrefs.SetFloat("Player Score", oldScore + score);
        }
        else PlayerPrefs.SetFloat("Player Score", 0);
    }

    void SubtractScore(float score)
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

    void StoreHighscore(int newHighscore)
    {
        int oldHighscore = PlayerPrefs.GetInt("highscore", 0);
        if (newHighscore > oldHighscore)
            PlayerPrefs.SetInt("highscore", newHighscore);
    }
}
