
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class PlusMinus : MonoBehaviour
{
    public GameObject Plus;
    public GameObject Minus;
    public Text price;

    public int money;


    //public void changeMoney()
    //{

    //    price.text = money + "";
    //}


     void Start()
    {
       
     price.text = ""+money;

    }

    void Update()
    {
        Button add = GetComponent<Button>();
        add.onClick.AddListener(Increase);

        Button minus = GetComponent<Button>();
        minus.onClick.AddListener(Decrease);

        price.text = "" +money;
    }



   void Increase()
    {
        money +=money;
       price.text =" "+money;

        //Button add = GetComponent<Button>();
        //Text price_text = GetComponent<Text>();
        //if (GetComponent<Button>() == add)
        //{
        //    int a = 0;
        //    a = a + 1;    // 也能簡寫為 a++; 或 a+=1;
        //    GetComponent<Text>().text = " " + a;    // 前面加空字串，是為了把 整數a 轉為 字串。
        //}
    }
       
   void Decrease()
    {

        money-=money;
        price.text = " " + money;

        //Button minus = GetComponent<Button>();
        //Text price_text = GetComponent<Text>();
        //if (GetComponent<Button>() == minus)
        //{
        //    int a = 100;
        //    a = a -1;    
        //    GetComponent<Text>().text = " " + a;    // 前面加空字串，是為了把 整數a 轉為 字串。
        //}
    }

    

}