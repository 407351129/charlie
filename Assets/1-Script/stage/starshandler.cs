using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starshandler : MonoBehaviour
{
    public GameObject[] stars;

    private bool end_map;

    // public static int map_time;
    private int end_time;

    public int currentStarNum = 0;

    public int levelIndex;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // void Update()
    // {
    //     end_map = Map_time.end_map;
    //     end_time = Map_time.e
    // }
    public void starAcheived(int _starNum)
    {
        currentStarNum = _starNum;
        if (currentStarNum > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, _starNum);
        }

        //int end_time = Map_time.end_time;
        //float end_times = float.Parse(end_time.ToString());
        //if(end_times > 10 && end_times < 20)
        {
            // end_map = true;
            stars[0].SetActive(true);
        }

        //else if(end_times > 20 && end_times < 30)
        {
            // end_map = true;
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }

        //else
        {
            // end_map = true;
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
    }
}
