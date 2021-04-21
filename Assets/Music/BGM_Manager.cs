using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Manager : MonoBehaviour
{
    public Text toggleMusciTxt;
    public Text toggleSfxTxt;
    public Text toggleSupTxt;

    private void Start()
    {
        if (BGM.Bg_Instance.Audio.isPlaying)
        {
            toggleMusciTxt.text = "OFF";
        }
        else
        {
            toggleMusciTxt.text = "ON";
        }

        if (SfxManager.sfxInstance.musicToggle == true)
        {
            toggleSfxTxt.text = "OFF";
        }
        else
        {
            toggleSfxTxt.text = "ON";
        }

        if (SupportManager.SupportInstance.musicToggle == true)
        {
            toggleSupTxt.text = "OFF";
        }
        else
        {
            toggleSupTxt.text = "ON";
        }

    }

    public void SupportToggle()
    {
        if (SupportManager.SupportInstance.musicToggle == true)
        {
            SupportManager.SupportInstance.musicToggle = false;
            toggleSupTxt.text = "ON";
        }
        else
        {
            SupportManager.SupportInstance.musicToggle = true;
            toggleSupTxt.text = "OFF";
        }
    }


    public void SfxToggle()
    {
        if (SfxManager.sfxInstance.musicToggle == true)
        {
            SfxManager.sfxInstance.musicToggle = false;
            toggleSfxTxt.text = "ON";
        }
        else
        {
            SfxManager.sfxInstance.musicToggle = true;
            toggleSfxTxt.text = "OFF";
        }
    }
    public void MusicToggle()
    {
        if (BGM.Bg_Instance.Audio.isPlaying)
        {
            BGM.Bg_Instance.Audio.Pause();
            toggleMusciTxt.text = "ON";
        }
        else
        {
            BGM.Bg_Instance.Audio.Play();
            toggleMusciTxt.text = "OFF";
        }
    }
}
