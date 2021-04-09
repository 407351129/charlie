using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelItem : MonoBehaviour
{
    // / <summary>
    // / 关卡ID
    // / </summary>
    private int LevelId;

    public int aaa;

    // / <summary>
    // / 创建按钮
    // / </summary>
    public Button level_btn;

    // Start is called before the first frame update
    void Awake()
    {
        level_btn = GetComponent<Button>();
        level_btn.onClick.AddListener (Level_OnClick);
    }

    // // Update is called once per frame
    // void Update()
    // {
    // }
    // /// <summary>
    // /// 初始化
    // /// </summary>
    // /// <param name="id">关卡ID</param>
    // /// <param name="isLock">是否锁住关卡</param>
    // public void Init(int id, bool isLock)
    // {
    //     LevelId = id;
    //     if (isLock)
    //     {
    //         btn.interactable = false;
    //     }
    //     else
    //     {
    //         btn.interactable = true;
    //     }
    // }
    // /// <summary>
    // /// 点击监听
    // /// </summary>
    private void Level_OnClick()
    {
        // aaa = 5;
        //场景加载，进入关卡
        //确保BuildSetting中的场景编号没有问题
        SceneManager.LoadScene(3);
    }
}
