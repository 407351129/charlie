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

    public string[] food = new string[4]; //每一關都不一樣,此處接資料庫的Order, 4的最後一個會被getfood蓋過

    public string getfood; //送餐至客戶家的

    public static string[] foods; //數值傳出去的地方 別人要接的數值  

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

    public void level_click() //在選擇關卡頁 點擊任何一個關卡
    {
        now_level = level_num; //目前關卡
        foods = food;
        foods[3] = getfood; //第3個是送餐至客戶家
    }

    void Start()
    {
        foods = new string[4];
        now_level = PlayerPrefs.GetInt("Lv");
        // PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("num"+1, 12345);
        //PlayerPrefs.SetInt("num"+2, 12);
        //PlayerPrefs.SetInt("numwewkoekwoekweowkoe", 1);
    }
  
}
