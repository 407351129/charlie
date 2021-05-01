using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;

    public int damage;
    public static int damage1 = 50;

    public int maxHP;
    public int currentHP;

    public void TakeDamage(int dmg)
    {
        currentHP -= dmg;
    }

    public void DefenseDamage(int dmg1)
    {
        currentHP -= dmg1;
    }

    public bool End()
    {
        if (currentHP <= 0) return true;
        else return false;
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }
}
