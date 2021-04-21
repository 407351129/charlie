using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class support_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void left_button()
    {
        if (SupportManager.SupportInstance.musicToggle == true)
            SupportManager.SupportInstance.Audio.PlayOneShot(SupportManager.SupportInstance.left);

    }

    // Update is called once per frame
    public void straight_button()
    {
        if (SupportManager.SupportInstance.musicToggle == true)
            SupportManager.SupportInstance.Audio.PlayOneShot(SupportManager.SupportInstance.straight);

    }

    public void right_button()
    {
        if (SupportManager.SupportInstance.musicToggle == true)
            SupportManager.SupportInstance.Audio.PlayOneShot(SupportManager.SupportInstance.right);

    }
    void Update()
    {

    }
}
