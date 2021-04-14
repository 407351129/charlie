using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip start;
    public AudioClip UI_click;
    public AudioClip attack;
    public AudioClip levelup;
    public bool musicToggle = true;
    public static SfxManager sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);

    }
}
