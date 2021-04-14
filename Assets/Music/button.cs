using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public AudioSource play;
    //点击按钮音效
    public void chick()
    {
        play.Play();


    }

}
