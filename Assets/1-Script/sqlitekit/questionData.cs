using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionData : MonoBehaviour

{
    public SqliteDatabase sqlDB;
   

    // Use this for initialization
    void Start()
    {
        //打开测试数据库
        sqlDB = new SqliteDatabase("charlieSQLite.db");
        //添加数据
        sqlDB.ExecuteNonQuery("INSERT INTO Questions (Questions_Content, Questions_Symbol, Questions_Chinese,Questions_Reward,Questions_Type) values('candy', 'tan','糖果',10,0)");
        print("添加数据完毕");

        PrintAllData();

        //根据id删除最后添加的数据
        sqlDB.ExecuteNonQuery("DELETE FROM Questions WHERE Questions_Id = (SELECT MAX(Questions_Id) FROM  Questions)");
        print("删除数据完毕");

        PrintAllData();
    }

    //控制台打印数据
    void PrintAllData()
    {
        //读取example表中所有数据
        DataTable dt = sqlDB.ExecuteQuery("SELECT * FROM Questions");
        //提取每行数据，遍历打印
        //int Questinos_Id;
       string Questions_Content;
       string Questions_Symbol;
       string Questions_Chinese;
        int Questions_Reward;
        int Questions_Type;


        foreach (DataRow dr in dt.Rows)
        {
            //Questinos_Id = (int)dr["Questions_Id"];
            Questions_Content = (string)dr["Questions_Content"];
            Questions_Symbol = (string)dr["Questions_Symbol"];
            Questions_Chinese = (string)dr["Questions_Chinese"];
            Questions_Reward = (int)dr["Questions_Reward"];
            Questions_Type = (int)dr["Questions_Type"];

            //print("id:" + (int)dr["id"]);
            print("name:" + Questions_Content);
            print("name:" + Questions_Symbol);
            print("name:" + Questions_Chinese);
            print("name:" + Questions_Reward);
            print("name:" + Questions_Type);

            //檢查在電腦上是否有連到資料庫用
            //Debug.Log("Questions_Content="+Questions_Content+"Questions_Symbol="+Questions_Symbol+"Questions_Chinese="+Questions_Chinese+"Questions_Reward="+Questions_Reward+"Questions_Type="+Questions_Type);

          


        }
    }
}
