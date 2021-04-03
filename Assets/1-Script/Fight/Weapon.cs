using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform attackEffect;
    public GameObject attackEffectPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    void Attack()
    {
        Instantiate(attackEffectPrefab, attackEffect.position, attackEffect.rotation);
    }
}
