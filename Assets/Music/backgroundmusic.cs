using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundmusic : MonoBehaviour
{
    private static backgroundmusic Backgroundmusic;
    // Start is called before the first frame update
    void Awake()
    {
        if (Backgroundmusic == null)
        {
            Backgroundmusic = this;
            DontDestroyOnLoad(Backgroundmusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
