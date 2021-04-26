using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public static int time = 30;

    public Text time_UI;

    public static bool time_out;

    public bool time_out_test;

    //public int time_test;
    // public bool time_out_test;
    // Start is called before the first frame update
    // void Start()
    // {
    // }
    void timer()
    {
        time -= 1;
        if (time == 0)
        {
            time_out = true;
            time_out_test = true;
            CancelInvoke("timer");
        }
        if (time != 30)
        {
            time_UI.text = time + "";
        }

        // time_test = time;
        // if (time == 0)
        // {
        //     time_UI.text = "0";

        //     // return;
        //     // CancelInvoke("timer");
        // }
    }

<<<<<<< HEAD
   // public void StartTimeCount()
  //  {
       // if (button_attack.fight_on == true)
   //     {
     //       time = 30;
       //     if (time == 30)
         //   {
           //     time_UI.text = time + "";
           // }
           // InvokeRepeating("timer", 1, 1);
           // time = 30;
=======
    public void StartTimeCount()
    {
        if (button_attack.fight_on == true)
        {
            CancelInvoke("timer");
            time = 30;
            if (time == 30)
            {
                time_UI.text = time + "";
            }
            InvokeRepeating("timer", 1, 1);
            time = 30;
>>>>>>> 01f14213245cf8838c9cccc1339b36827474ac84
            // time_out_test = time_out;
            // // if (time == 0)
            // {
            //     time_out_test = true;
            // }

            // time_test = time;
   //     }
   // }
}
