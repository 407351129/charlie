
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusMinus : MonoBehaviour
{

    public GameObject Plus;
    public GameObject Minus;
    public Text price;
    public int money; //單價
    //public int item_num; //數量
    public int total; //總價格




    void Start()
    {
        money = 100;
        //item_num=4; 

        total = save_itemNum.item_num * money; //item_num 為public variable ,已預先設好item_num 引用過來 (暫時)
        PlayerPrefs.SetInt("Price", total);
        price.text = total + "";


    }

    void Update()
    {
        Button add = GetComponent<Button>();
        if (add != null) //一定要加這行 不然會有NullReferenceException: Object reference not set to an instance of an object的Error
        {
            add.onClick.AddListener(Increase);
        }


        Button minus = GetComponent<Button>();

        if (minus != null) //同add相同原因
        {
            minus.onClick.AddListener(Decrease);
        }



        total = save_itemNum.item_num * money;
        price.text = total + "";

    }





    public void Increase() //按下去 購買數量增加
    {


        save_itemNum.item_num += 1;
        total = save_itemNum.item_num * money;
        PlayerPrefs.SetInt("Price", total);
        price.text = total + "";


        //Button add = GetComponent<Button>();
        //Text price_text = GetComponent<Text>();
        //if (GetComponent<Button>() == add)
        //{
        //    int a = 0;
        //    a = a + 1;    // 也能簡寫為 a++; 或 a+=1;
        //    GetComponent<Text>().text = " " + a;    // 前面加空字串，是為了把 整數a 轉為 字串。
        //}
    }

    public void Decrease() //按下去 購買數量減少
    {

        if (save_itemNum.item_num > 1)
        {
            save_itemNum.item_num -= 1;
            total = save_itemNum.item_num * money;
            PlayerPrefs.SetInt("Price", total);
            price.text = total + "";


        }

        //Button minus = GetComponent<Button>();
        //Text price_text = GetComponent<Text>();
        //if (GetComponent<Button>() == minus)
        //{
        //    int a = 100;
        //    a = a -1;    
        //    GetComponent<Text>().text = " " + a;    // 前面加空字串，是為了把 整數a 轉為 字串。
        //}
    }


    //total+=item_num* money; //持有金幣加

}