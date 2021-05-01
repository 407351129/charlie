using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// using UnityEngine.UI;
public class Map_time : MonoBehaviour
{
    public static int map_time;
    
    public int test_map_time;

    [SerializeField]
    private bool end_map; //之後接值

    [SerializeField]
    private int map_fight_index;
    public GameObject[] stars;
    public static bool map_start;
    
    [SerializeField]
    private bool test_map_start;
    [SerializeField]
    private int now_level;
    


    [SerializeField]
    private int end_time;
    public Canvas game_clear;
    private int currentStarNum = 0;


    // [SerializeField]
    // int hi;
    // public GameObject time_map;
    // public GameObject o_map_time;
    void Awake()
    {
        test_map_start = map_start;

        // InvokeRepeating("timer", 1, 1);
        // hi = 0;
        map_fight_index = SceneManager.GetActiveScene().buildIndex;
        GameObject time_map = GameObject.Find("map_time");

        //  monster1 = GameObject.Find("monster1");
        if (
            map_fight_index == 8 ||
            map_fight_index == 3 ||
            map_fight_index == 4 ||
            map_fight_index == 5 ||
            map_fight_index == 2
        )
        {
            // if (map_fight_index == 8)
            // {
            DontDestroyOnLoad(time_map);
        }
        else
        {
            Destroy(time_map);

            // exit_map = true;
        }
        if (map_fight_index == 2)
        {
            // CancelInvoke("timer");
            // time = 0;
        }
        if (map_start == false)
        {
            // exit_map = true;
            // InvokeRepeating("timer", 1, 1);
        }

        // Destroy(this.gameObject);

        // if (exit_map == false)
        // {
        //     DontDestroyOnLoad(this);
        // }
        // if ()
        // {
        //     Destroy(this.gameObject);
        // }
    }

    void Start()
    {
        now_level =PlayerPrefs.GetInt("Lv");
        //PlayerPrefs.DeleteAll();
        // if (map_start == true)
        // {
        InvokeRepeating("timer", 1, 1);
        // }
    }

    void go_to_map()
    {
        // Awake();
        GameObject map_setting = GameObject.Find("map_setting");
        // map_fight_index = 8;
        if (
            map_fight_index == 8 ||
            map_fight_index == 3 ||
            map_fight_index == 4 ||
            map_fight_index == 5 ||
            map_fight_index == 2
        )
        {
            DontDestroyOnLoad(map_setting);
        }
        else
        {
            Destroy(map_setting);
        }
    }

    public void map_time_start()
    {
        map_start = true;

        // map_time = 555;
        // InvokeRepeating("timer", 1, 1);
        // map_time += 1;
    }

    // public void zero_time_click()
    // {
    //     exit_map = true;
    // }

    //public void star(int _starNUM)
    //{
     //   currentStarNum = _starNUM;
    //}


    //void Map_Star()
    //{
    //    now_level = levelstars.now_level;
     //   test_map_start = map_start;
    ////    test_map_time = map_time;
      //  if (end_map == true)
     //   {
      //      game_clear.gameObject.SetActive(true);
      //      map_start = false;
      //      if (end_time >= 0 && end_time < 10)
      //      {
      //          stars[0].SetActive(true);
      //          stars[1].SetActive(true);
      //          stars[3].SetActive(true);
      //          currentStarNum = 3;
                //PlayerPrefs.SetInt("num" + 2, 12);


                //if (3 > PlayerPrefs.GetInt("Lv" + now_level))
                //{
                //    PlayerPrefs.SetInt("Lv" + now_level, 3);
                //}


                //PlayerPrefs.SetInt("Lv" + now_level, _starNUM);

        //    }
        //    else if (end_time >= 10 && end_time < 20)
        //    {
        //        stars[0].SetActive(true);
       //         stars[1].SetActive(true);
        //        currentStarNum = 2;
                //PlayerPrefs.SetInt("num" + 2, 12);


                //if (2 > PlayerPrefs.GetInt("Lv" + now_level))
                //{
                //PlayerPrefs.SetInt("Lv" + now_level, 2);
                //}

        //    }
        //    else if (end_time >= 30)
         //   {
         //       stars[0].SetActive(true);
         //       currentStarNum = 1;
                //PlayerPrefs.SetInt("num" + 2, 12);


                //if (1 > PlayerPrefs.GetInt("Lv" + now_level))
                //{
                //    PlayerPrefs.SetInt("Lv" + now_level, 1);
                //}
          //  }

        //}
      //  else
       // {
            //currentStarNum = 0;
            //PlayerPrefs.SetInt("num" + 2, 111112);

        //   game_clear.gameObject.SetActive(false);
       // }
  //  }
    void Update()
    {
        map_fight_index = SceneManager.GetActiveScene().buildIndex;

        now_level = levelstars.now_level;
        test_map_start = map_start;
        test_map_time = map_time;
        if (end_map == true)
        {
            game_clear.gameObject.SetActive(true);
            map_start = false;
            if (end_time < 10)  //10秒內完成關卡 得3顆星
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
                currentStarNum = 3;
                //PlayerPrefs.SetInt("num" + 2, 12);


                if (currentStarNum > PlayerPrefs.GetInt("Lv" + now_level))
                {
                    PlayerPrefs.SetInt("Lv" + now_level, 3);
                }
                



                //PlayerPrefs.SetInt("Lv" + now_level, _starNUM);

            }
            else if (end_time < 20) 
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(false);
                currentStarNum = 2;
                //PlayerPrefs.SetInt("num" + 2, 12);


                if (2 > PlayerPrefs.GetInt("Lv" + now_level))
                {
                    PlayerPrefs.SetInt("Lv" + now_level, 2);
                }

            }
            else
            {
                stars[0].SetActive(true);
                stars[1].SetActive(false);  
                stars[2].SetActive(false);
                currentStarNum = 1;
                //PlayerPrefs.SetInt("num" + 2, 12);


                if (1 > PlayerPrefs.GetInt("Lv" + now_level))
                {
                    PlayerPrefs.SetInt("Lv" + now_level, 1);
                }

            }

        }
        else
        {
            //currentStarNum = 0;
            //PlayerPrefs.SetInt("num" + 2, 111112);

            game_clear.gameObject.SetActive(false);
        }

        if (
            map_fight_index == 8 ||
            map_fight_index == 3 ||
            map_fight_index == 4 ||
            map_fight_index == 5
        )
        {
            if (end_map == false)
            {
                end_time = map_time;
            }

            // if (map_start == true)
            // {
            //     InvokeRepeating("timer", 1, 1);
            // }
            // map_time = 0;
            // InvokeRepeating("timer", 1, 1);
            // CancelInvoke("timer");
        }
        else if (map_fight_index == 2 && map_start == false)
        {
            map_time = 0;
            // CancelInvoke("timer");
        }
        go_to_map();
    }

    void timer()
    {
        map_time += 1;
    }

    // public void map_time_start(){

    // }
}

//     public GameObject time_map;

//     public GameObject time_map_monster;

//     // public Text map_time_UI;
//     // public static bool time_out;
//     // public bool time_out_test;
//     // public int time_test;
//     public bool end_map;

//     private GameObject o_map_time;

//     // public bool time_out_test;
//     // Start is called before the first frame update
//     private void Awake()
//     {
//         // o_map_time
//         // if (people_map.fight_notice != true)
//         // {
//         //     Destroy(this.gameObject);
//         //     return;
//         // }
//         // sfxInstance = this;
//         //如果食物送完
//         // if (o_map_time == null)
//         // {
//         //     o_map_time = this.gameObject;
//         //     DontDestroyOnLoad (o_map_time);
//         // }
//         // else
//         // {
//         //     Destroy (gameObject);
//         // }
//         // if(GameObject.Find("map_time") = null){
//         //     DontDestroyOnLoad(this);
//         // }else{
//         //     Destroy(this.gameObject);
//         // }
//     }

//     void Start()
//     {
//         map_time = 0;
//         end_map = false;

//         if (end_map == true)
//         {
//             CancelInvoke("timer");
//         }
//         else if (
//             // map_time == 0)
//             (
//             time_map.activeInHierarchy == true &&
//             time_map_monster.activeInHierarchy == true
//             ) ||
//             map_to_fight == true
//         )
//         {
//             InvokeRepeating("timer", 1, 1);
//         }
//         else
//         {
//             CancelInvoke("timer");
//             Destroy(this.gameObject);

//             // DestroyOnLoad(this);
//         }
//     }

//     void timer()
//     {
//         map_time += 1;

//         // if (end_map == true)
//         // {
//         //     map_time = 0;
//         //     CancelInvoke("timer");
//         // }
//         // else if (
//         //     time_map.activeInHierarchy == true &&
//         //     time_map_monster.activeInHierarchy == true
//         // )
//         // {
//         //     InvokeRepeating("timer", 1, 1);
//         // }
//         // else if (fight_on
//         // )
//         // {
//         //     InvokeRepeating("timer", 1, 1);
//         // }
//         // else
//         // {
//         //     CancelInvoke("timer");
//         //     // Destroy(this.gameObject);

//         //     // DestroyOnLoad(this);
//         // }
//         // if (map_time == 0)
//         // {
//         //     time_out_test = true;
//         //     // CancelInvoke("timer");
//         // }
//         // if (time != 30)
//         // {
//         //     time_UI.text = time + "";
//         // }

//         // map_time_test = map_time;
//         // if (map_time == 0)
//         // {
//         //     map_time_UI.text = "0";

//         //     // return;
//         //     // CancelInvoke("map_timer");
//         // }
//     }

//     public void StartTimeCount()
//     {
//         // if (button_fi.fight_on == true)
//         // {
//         // map_time = 0;
//         // if (map_time == 0)
//         // {
//         //     map_time_UI.text = time + "";
//         // }
//         // map_time = 30;
//         // time_out_test = time_out;
//         // // if (time == 0)
//         // {
//         //     time_out_test = true;
//         // }
//         // time_test = time;
//         // }
//     }

//     // using System.Collections;
//     // using System.Collections.Generic;
//     // using UnityEngine;

//     // public class SfxManager : MonoBehaviour
//     // {
//     //     public AudioSource Audio;
//     //     public AudioClip start;
//     //     public AudioClip UI_click;
//     //     public AudioClip attack;
//     //     public AudioClip levelup;
//     //     public bool musicToggle = true;
//     //     public static SfxManager sfxInstance;

//     //     private void Awake()
//     //     {
//     //         if (sfxInstance != null && sfxInstance != this)
//     //         {
//     //             Destroy(this.gameObject);
//     //             return;
//     //         }
//     //         sfxInstance = this;
//     //         DontDestroyOnLoad(this);

//     //     }
//     // }
// }