using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public static BGM Bg_Instance;
    public AudioSource Audio;
    // Start is called before the first frame update

    // Start is called before the first frame update
    private void Awake()
    {
        if (Bg_Instance != null && Bg_Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Bg_Instance = this;
        DontDestroyOnLoad(this);

    }
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
