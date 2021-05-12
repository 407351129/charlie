using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionData : MonoBehaviour
{
    public SqliteDatabase sqlDB;

    
    public Text Chinese;
    public Text Pinin;
    public Text English;
    //public int id;
    //public int type;


    //提取每行数据，遍历打印
    int Questions_Id;
    string Questions_Content;
    string Questions_Symbol;
    public static string Questions_Chinese;
    int Questions_Reward;
    int Questions_Type;



    // Use this for initialization
    void Start()
    {
        //打开测试数据库
        sqlDB = new SqliteDatabase("charlieSQLite.db");

        //读取example表中所有数据
        //DataTable dt = sqlDB.ExecuteQuery("SELECT * FROM Questions");

        switch (Questions_Type)
        {

            case 0:
                ArriveQ();
                break;

            case 1:
                OrderQ(3); //暫時卡死在1~3
                break;

            case 2:
                RunQ();
                break;

            case 3:
                BattleQ(5);//暫時卡死在1到5題
                break;

            default:
                OrderQ(3);
                break;
        }
     
            //Debug.Log("目前英文:" + Questions_Content);
            //Debug.Log("目前讀音:" + Questions_Symbol);
            //Debug.Log("目前中文:" + Questions_Chinese);

            //Debug.Log("目前id:" + Questions_Id);
            //Debug.Log("目前type:" + Questions_Type);
 




    }

    //控制台打印数据  (目前仍必須留 否則下方method全部失效
    void PrintAllData()
    {
        //读取example表中所有数据
        DataTable dt = sqlDB.ExecuteQuery("SELECT * FROM Questions" );

        //提取每行数据，遍历打印
        int Questions_Id;
        string Questions_Content;
        string Questions_Symbol;
        string Questions_Chinese;
        int Questions_Reward;
        int Questions_Type;

        foreach (DataRow dr in dt.Rows)
        {
            Questions_Id = (int)dr["Questions_Id"];
            Questions_Content = (string) dr["Questions_Content"];
            Questions_Symbol = (string) dr["Questions_Symbol"];
            Questions_Chinese = (string) dr["Questions_Chinese"];
            Questions_Reward = (int) dr["Questions_Reward"];
            Questions_Type = (int) dr["Questions_Type"];

            //print("id:" + (int)dr["id"]);
            //print("name:" + Questions_Content);
            //print("name:" + Questions_Symbol);
            //print("name:" + Questions_Chinese);
            //print("name:" + Questions_Reward);
            //print("name:" + Questions_Type);



            English.text = Questions_Content;
            Pinin.text = Questions_Symbol;
            Chinese.text = Questions_Chinese;



            Debug.Log("目前英文:" + Questions_Content);
            Debug.Log("目前讀音:" + Questions_Symbol);
            Debug.Log("目前中文:"+ Questions_Chinese);

            Debug.Log("目前id:" + Questions_Id);
            Debug.Log("目前type:" + Questions_Type);

        }

     }


    public void ArriveQ() //送餐至客戶家(短句) type 0
    {

        DataTable dt = sqlDB.ExecuteQuery("SELECT * FROM Questions WHERE Questions_Type = 0 ORDER BY random() LIMIT 1"); //亂數選type 0 題目

        foreach (DataRow dr in dt.Rows)  //搜尋結果各欄儲存在dictionary 
        {
            Questions_Id = (int)dr["Questions_Id"];
            Questions_Content = (string)dr["Questions_Content"];
            Questions_Symbol = (string)dr["Questions_Symbol"];
            Questions_Chinese = (string)dr["Questions_Chinese"];
            Questions_Reward = (int)dr["Questions_Reward"];
            Questions_Type = (int)dr["Questions_Type"];

        }

        English.text = Questions_Content;
        Pinin.text = Questions_Symbol;
        Chinese.text = Questions_Chinese;



        Debug.Log("目前英文:" + Questions_Content);
        Debug.Log("目前讀音:" + Questions_Symbol);
        Debug.Log("目前中文:" + Questions_Chinese);

        Debug.Log("目前id:" + Questions_Id);
        Debug.Log("目前type:" + Questions_Type);

    }






    public void OrderQ(int question_id) //訂單、送餐題目(食物單字) type 1
    {

        DataTable dt = sqlDB.ExecuteQuery("SELECT * FROM Questions WHERE Questions_Id BETWEEN 1 AND 3 ORDER BY random() LIMIT 1"); //限制1到3 (還沒寫好 

        foreach (DataRow dr in dt.Rows)  //搜尋結果各欄儲存在dictionary 
        {
            Questions_Id = (int)dr["Questions_Id"];
            Questions_Content = (string)dr["Questions_Content"];
            Questions_Symbol = (string)dr["Questions_Symbol"];
            Questions_Chinese = (string)dr["Questions_Chinese"];
            Questions_Reward = (int)dr["Questions_Reward"];
            Questions_Type = (int)dr["Questions_Type"];

            English.text = Questions_Content;
            Pinin.text = Questions_Symbol;
            Chinese.text = Questions_Chinese;
        }


       



        Debug.Log("目前英文:" + Questions_Content);
        Debug.Log("目前讀音:" + Questions_Symbol);
        Debug.Log("目前中文:" + Questions_Chinese);

        Debug.Log("目前id:" + Questions_Id);
        Debug.Log("目前type:" + Questions_Type);

    }



    public void RunQ() //逃跑題目(長句) type 2

    {
        DataTable dt = sqlDB.ExecuteQuery("SELECT * FROM Questions WHERE Questions_Type = 2 ORDER BY random() LIMIT 1"); ////亂數選type2句子

        foreach (DataRow dr in dt.Rows)  //搜尋結果各欄儲存在dictionary 
        {
            Questions_Id = (int)dr["Questions_Id"];
            Questions_Content = (string)dr["Questions_Content"];
            Questions_Symbol = (string)dr["Questions_Symbol"];
            Questions_Chinese = (string)dr["Questions_Chinese"];
            Questions_Reward = (int)dr["Questions_Reward"];
            Questions_Type = (int)dr["Questions_Type"];

        }


        English.text = Questions_Content;
        Pinin.text = Questions_Symbol;
        Chinese.text = Questions_Chinese;



        Debug.Log("目前英文:" + Questions_Content);
        Debug.Log("目前讀音:" + Questions_Symbol);
        Debug.Log("目前中文:" + Questions_Chinese);

        Debug.Log("目前id:" + Questions_Id);
        Debug.Log("目前type:" + Questions_Type);

    }





    public void BattleQ(int question_id) //和怪物戰鬥時的題目(食物單字) type 3
    {

        DataTable dt = sqlDB.ExecuteQuery("SELECT * FROM Questions WHERE Questions_Id BETWEEN 1 AND 5 ORDER BY random() LIMIT 1"); //id 1~5題目 隨機出現

        foreach (DataRow dr in dt.Rows)  //搜尋結果各欄儲存在dictionary 
        {
            Questions_Id = (int)dr["Questions_Id"];
            Questions_Content = (string)dr["Questions_Content"];
            Questions_Symbol = (string)dr["Questions_Symbol"];
            Questions_Chinese = (string)dr["Questions_Chinese"];
            Questions_Reward = (int)dr["Questions_Reward"];
            Questions_Type = (int)dr["Questions_Type"];

        }


        English.text = Questions_Content;
        Pinin.text = Questions_Symbol;
        Chinese.text = Questions_Chinese;



        Debug.Log("目前英文:" + Questions_Content);
        Debug.Log("目前讀音:" + Questions_Symbol);
        Debug.Log("目前中文:" + Questions_Chinese);

        Debug.Log("目前id:" + Questions_Id);
        Debug.Log("目前type:" + Questions_Type);




    

    }




   






}
