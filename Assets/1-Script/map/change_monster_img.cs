using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_monster_img : MonoBehaviour
{
    private int ff;

    // Start is called before the first frame update
    void Start()
    {
        ff = people_map.which_monster;
        GameObject prueba = new GameObject("prueba");
        SpriteRenderer renderer = prueba.AddComponent<SpriteRenderer>();
        Object[] sprites;
        sprites =
            Resources
                .LoadAll
                <Sprite>("Assets/2-Character/test/Assets/PackForest01.png");
        if (ff == 1)
        {
            renderer.sprite = (Sprite) sprites[1];
        }
        else if (ff == 2)
        {
            renderer.sprite = (Sprite) sprites[1];
        }
        else if (ff == 3)
        {
            renderer.sprite = (Sprite) sprites[1];
        }
    }

    // Update is called once per frame
    // void Update()
    // {

    // }
}
