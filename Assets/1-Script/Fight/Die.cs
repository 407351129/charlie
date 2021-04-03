using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Die : MonoBehaviour
{
    public GameObject die;

    public void EnableDie(bool enabled)
    {
        die.SetActive(enabled);
    }
}
