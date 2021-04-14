using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButton: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void UIButtonSound()
    {
        if(SfxManager.sfxInstance.musicToggle == true)
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.UI_click);
        
    }

    // Update is called once per frame
    public void startButtonSound()
    {
        if (SfxManager.sfxInstance.musicToggle == true)
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.start);
      
    }
    void Update()
    {

    }
}
