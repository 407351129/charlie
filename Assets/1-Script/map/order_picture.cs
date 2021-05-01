using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class order_picture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite =
            (Sprite) Resources.Load<Sprite>("food/牛肉");
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
