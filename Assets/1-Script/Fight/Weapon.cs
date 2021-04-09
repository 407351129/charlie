using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform attackEffect;
    public GameObject attackEffectPrefab;

    public void Attack()
    {
        Instantiate(attackEffectPrefab, attackEffect.position, attackEffect.rotation);
    }
}
