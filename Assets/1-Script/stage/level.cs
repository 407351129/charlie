using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    // Start is called before the first frame update
    private static level Level;
    // Start is called before the first frame update
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }
    public void PressStageButton()
    {
        Application.LoadLevel(2);
    }
}
