using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndNotice : MonoBehaviour
{
    public GameObject die;
    public GameObject win;

    public void EnableDie(bool enabled)
    {
        die.SetActive(enabled);
    }

    public void EnableWin(bool enabled)
    {
        win.SetActive(enabled);
    }
}
