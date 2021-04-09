using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieNotice : MonoBehaviour
{
    public GameObject dieNotice;

    public void EnableDieNotice(bool enabled)
    {
        dieNotice.SetActive(enabled);
    }
}
