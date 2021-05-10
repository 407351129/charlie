using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyPlayer : MonoBehaviour
{
    public Text Coin;
    public int coin_int;

     void Start()
    {
        if (PlayerPrefs.HasKey("Player Money"))//若playerpref檢查有player money紀錄
        {
             coin_int = PlayerPrefs.GetInt("Player Money"); //獲取player money
            PlayerPrefs.SetInt("Player Money", coin_int);
            Coin.text = coin_int+"";
        }
        else
        {
            PlayerPrefs.SetInt("Player Money", 1000);//若playerpref沒有存金幣紀錄  初始設為1000
            coin_int = 1000;
            Coin.text = coin_int+"";

        }

        Debug.Log("開始時coin_int=" + coin_int);

    }




    public void Earn(int earn_int) //玩外送遊戲賺的錢  (還沒測試
    {
            int oldCoin = PlayerPrefs.GetInt("Player Money"); //獲取player money 玩家原本的錢
        earn_int = PlayerPrefs.GetInt("Earned"); //取得賺到的錢

        Debug.Log("還沒買前oldCoin=" + oldCoin);
        Debug.Log("還沒扣前coin_int=" + coin_int);
        Debug.Log("賺取earn_int=" + earn_int);

        PlayerPrefs.SetInt("Player Money", oldCoin + earn_int);//加上去
            coin_int= PlayerPrefs.GetInt("Player Money"); //更新加完後現在玩家擁有的錢
            Coin.text = coin_int+"";

        Debug.Log("加完coin_int=" + coin_int);



        PlayerPrefs.SetInt("Earned", 0); //賺到錢清零
        earn_int = PlayerPrefs.GetInt("Earned");

        Debug.Log("賺取應該為0 earn_int=" + earn_int);


    }


   public void Cost(int total_int) //升級、購買扣錢
    {
      
            int oldCoin = PlayerPrefs.GetInt("Player Money"); //取得玩家原本的錢
            total_int = PlayerPrefs.GetInt("Price"); //取得總價格

        Debug.Log("還沒買前oldCoin=" + oldCoin);
        Debug.Log("還沒扣前coin_int=" + coin_int);
        Debug.Log("總價格total_int=" + total_int);

        if ((oldCoin - total_int) > 0) 
            {
          
            PlayerPrefs.SetInt("Player Money", oldCoin - total_int);
            coin_int = PlayerPrefs.GetInt("Player Money"); //更新買完後現在玩家擁有的錢
            Coin.text = coin_int + "";

            


            Debug.Log("買完coin_int="+ coin_int);

        }

             else   //若玩家錢不夠
            {
            coin_int = PlayerPrefs.GetInt("Player Money"); //現在玩家擁有的錢
            Coin.text = coin_int + "";

            Debug.Log("沒買coin_int=" + coin_int);

            Debug.Log("沒錢啦"); //(之後改跳通知

            }

        PlayerPrefs.SetInt("Price", 0); //總價清零
        total_int = PlayerPrefs.GetInt("Price");

        Debug.Log("總價應該為0 total_int="+ total_int);

    }
       



    }


  

