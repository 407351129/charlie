using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelstars : MonoBehaviour
{
    [SerializeField]
    private bool unlocked;

    public Image UnlockImage;

    public GameObject[] star;

    public GameObject[] numbertext;

    public static int now_level;

    public int level_num;

    public string[] food = new string[4];

    public static string[] foods;

    int stars;

    // Start is called before the first frame update
    public void Update()
    {
        UpdateLevelImage();
    }

    public void UpdateLevelImage()
    {
        if (!unlocked)
        {
            UnlockImage.gameObject.SetActive(true);

            // for(int i=0; i<star.Length; i++)
            // {
            //     star[i].gameObject.SetActive(false);
            // }
            for (int i = 0; i < numbertext.Length; i++)
            {
                numbertext[i].gameObject.SetActive(false);
                //PlayerPrefs.SetInt("num" + now_level, 2);
            }
        }
        else
        {
            UnlockImage.gameObject.SetActive(false);

            // for (int i = 0; i < star.Length; i++)
            // {
            //     star[i].gameObject.SetActive(true);
            // }
            for (int i = 0; i < PlayerPrefs.GetInt("Lv" + level_num); i++)
            {
                star[i].gameObject.SetActive(true);
            }
            for (int i = 0; i < numbertext.Length; i++)
            {
                numbertext[i].gameObject.SetActive(true);
            }
        }
    }

    public void level_click()
    {
        now_level = level_num;
        foods = food;
    }

    void Start()
    {
        food = new string[4];
        now_level = PlayerPrefs.GetInt("Lv");
        // PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("num"+1, 12345);
        //PlayerPrefs.SetInt("num"+2, 12);
        //PlayerPrefs.SetInt("numwewkoekwoekweowkoe", 1);
    }
    // Update is called once per frame
}
