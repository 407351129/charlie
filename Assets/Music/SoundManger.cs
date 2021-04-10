using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManger : MonoBehaviour
{
    [SerializeField] Image soundOnIcon; //將變數顯示在 editor 上
    [SerializeField] Image soundOffIcon;  //將變數顯示在 editor    上
    private bool muted = false; //宣告來儲存true或false的變數
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("mute")) //如果沒有儲存的data
        {
            PlayerPrefs.SetInt("mute", 0); //muted set to fasle 
            Load();
        }
        else
        {
            Load(); //如果有儲存到data就call load() function
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnbuttonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;  //當點下按鈕而且音樂不是靜音的狀況下會將所有音樂靜音
        }
        else
        {
            muted = false;
            AudioListener.pause = false; //如果遊戲是靜音的壯況下點下按鈕 會讓音樂啟動
        }
        Save();
        UpdateButtonIcon();
    }

    public void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundOnIcon.enabled = true; //讓soundOnIcon圖示顯示
            soundOffIcon.enabled =false;
        }
        else
        {
            soundOnIcon.enabled = false;//讓soundOffIcon圖示顯示
            soundOffIcon.enabled = true;
        }
    }
    
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1; //如果muted = 1 set to true 如果muted不是1就是0 ,muted = 0 set to false
    }
    
    private void Save()
    {
        PlayerPrefs.SetInt("muted",muted ? 1: 0 ); //判斷bool muted是1 or 0 並用PlayerPrefs儲存muted的性質 如果muted=true save as 1 如果muted=false save as 0
                                                   
    }

}
