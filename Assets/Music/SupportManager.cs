using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip left;
    public AudioClip straight;
    public AudioClip right;
    public bool musicToggle = true;
    public static SupportManager SupportInstance;

    private void Awake()
    {
        if (SupportInstance != null && SupportInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        SupportInstance = this;
        DontDestroyOnLoad(this);

    }
}
