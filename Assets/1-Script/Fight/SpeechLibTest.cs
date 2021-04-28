using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpeechLib;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

public class SpeechLibTest : MonoBehaviour
{
    public Text outputText;
    public Button startPlaButton;
    private bool waitingForPla;
    private object threadLocker = new object();

    public async void ButtonClick()
    {
        lock (threadLocker)
        {
            waitingForPla = true;
        }
    }

    //声明 SpVoice 对象
    SpVoice voice;
    void Start()
    {
        //实例化 SpVoice 对象
        voice = new SpVoice();
        //管理语音属性，注释掉的情况下下面也可以正常执行
        voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
        //语音速度，范围-10到10，默认是0
        voice.Rate = -8;
        //语音音量，范围0到100，默认是100
        voice.Volume = 100;

            startPlaButton.onClick.AddListener(ButtonClick);
    }

    void Update()
    {
        if (waitingForPla == true)
        {

            //同步朗读(同步朗读时系统会停在这里，直到朗读完毕才会往下执行，建议使用异步朗读)
            //voice.Speak("hello world");
            //异步朗读
            voice.Speak(outputText.text, SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }
        lock (threadLocker)
        {
            waitingForPla = false;
        }
    }
}
