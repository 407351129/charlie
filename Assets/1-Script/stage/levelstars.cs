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

<<<<<<< HEAD

=======
    public string[] food = new string[4];
>>>>>>> 5f51138204529f8ad272a316a25b5b71b3271117

    public string getfood;

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
<<<<<<< HEAD

 
=======
        foods = food;
        foods[3] = getfood;
>>>>>>> 5f51138204529f8ad272a316a25b5b71b3271117
    }

    void Start()
    {
<<<<<<< HEAD


        now_level =PlayerPrefs.GetInt("Lv");
       // PlayerPrefs.DeleteAll();
=======
        foods = new string[4];
        now_level = PlayerPrefs.GetInt("Lv");
        // PlayerPrefs.DeleteAll();
>>>>>>> 5f51138204529f8ad272a316a25b5b71b3271117
        //PlayerPrefs.SetInt("num"+1, 12345);
        //PlayerPrefs.SetInt("num"+2, 12);
        //PlayerPrefs.SetInt("numwewkoekwoekweowkoe", 1);
    }
    // Update is called once per frame
}
