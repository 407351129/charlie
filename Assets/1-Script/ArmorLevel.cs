﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorLevel : MonoBehaviour
{
    public GameObject level1Armors;

    public GameObject level1CurrentArmors;

    public GameObject level2Armors;

    public GameObject level2CurrentArmors;

    public GameObject level3Armors;

    public GameObject level3CurrentArmors;

    public GameObject levelNotice;

    public GameObject warning;

    public Text moneyEN;

    public Text moneyCH;

    public int level_int = 1;

    public int level_prefs;

    public Text levelText;

    //public int coin;

    public int playerMoney;

    void Start()
    {
        EnableWarning(false);
        EnableLevelNotice(false);
        level_int = 1;
    }

    public void SetLevel()
    {
        if (level_int < 3)
        {
            if (level_int < level_prefs)
            {
                level_int = level_prefs;
            }
            level_int++;
            Debug.Log("裝備:" + level_int);
            PlayerPrefs.SetInt("level_int", level_int);
            Debug.Log("裝備:" + level_int);
            Debug.Log("裝備等級:" + level_prefs);
        }
        EnableLevelNotice(false);
    }

    public void LevelNotice()
    {
        if (level_int < 3) EnableLevelNotice(true);
    }

    public void LevelNoticeOff()
    {
        EnableLevelNotice(false);
    }

    public void NoMoney()
    {
        if (level_int == 1)
        {
            if (playerMoney < 50) EnableWarning(true);
        }
        else if (level_int == 2)
        {
            if (playerMoney < 80) EnableWarning(true);
        }
    }

    void Armor()
    {
        if (level_int == 1)
        {
            EnableLevel2(false);
            EnableLevel3(false);
            EnableLevel1(true);
        }
        else if (level_int == 2)
        {
            EnableLevel1(false);
            EnableLevel3(false);
            EnableLevel2(true);
        }
        else if (level_int == 3)
        {
            EnableLevel1(false);
            EnableLevel2(false);
            EnableLevel3(true);
        }
    }

    void Money()
    {
        if (level_int == 1)
        {
            moneyEN.text = "50";
            moneyCH.text = "50";
        }
        else if (level_int == 2)
        {
            moneyEN.text = "80";
            moneyCH.text = "80";
        }
    }

    public void EnableLevel1(bool enabled)
    {
        level1Armors.SetActive(enabled);
        level1CurrentArmors.SetActive(enabled);
    }

    public void EnableLevel2(bool enabled)
    {
        level2Armors.SetActive(enabled);
        level2CurrentArmors.SetActive(enabled);
    }

    public void EnableLevel3(bool enabled)
    {
        level3Armors.SetActive(enabled);
        level3CurrentArmors.SetActive(enabled);
    }

    public void EnableLevelNotice(bool enabled)
    {
        levelNotice.SetActive(enabled);
    }

    public void EnableWarning(bool enabled)
    {
        warning.SetActive(enabled);
    }

    void Update()
    {
        playerMoney = PlayerPrefs.GetInt("Player Money");
        level_prefs = PlayerPrefs.GetInt("level_int");
        levelText.text = level_int.ToString();
        if (level_int < level_prefs) level_int = level_prefs;
        Armor();
        Money();

        //if (level_prefs == 0)
        //{
        //    level_prefs = 1;
        //    levelText.text = level_prefs.ToString();
        //}
    }
}
