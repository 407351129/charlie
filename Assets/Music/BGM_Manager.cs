using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Manager : MonoBehaviour
{
    public Text toggleMuscitxt;
    public Text toggleSfxTxt;

    private void Start()
    {
        if (BGM.Bg_Instance.Audio.isPlaying)
        {
            toggleMuscitxt.text = "OFF";
        }
        else
        {
            toggleMuscitxt.text = "ON";
        }
        if (SfxManager.sfxInstance.musicToggle == true)
        {
            toggleSfxTxt.text = "OFF";
        }
        else
        {
            toggleSfxTxt.text = "ON";
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
            toggleMuscitxt.text = "ON";
        }
        else
        {
            BGM.Bg_Instance.Audio.Play();
            toggleMuscitxt.text = "OFF";
        }
    }
}
