﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public DialogueText dialogueText;
    public EndNotice endNotice;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public Weapon fireball;
    
    public BattleState state;

    public static bool monster_alive; //這裡

    // Start is called before the first frame update
    // void Awake(){
        
    // }
    void Start()
    {
        monster_alive = true;
        state = BattleState.START;
        StartCoroutine(SetupBattle());        
    }

    IEnumerator SetupBattle()
    {
        PlayerAttackOff();
        endNotice.EnableDie(false);
        endNotice.EnableWin(false);

        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();
        
        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();
        
        yield return dialogueText.TypeDialogue("Choose an action!");
        yield return new WaitForSeconds(1f);

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        dialogueText.EnableActions(true);

        state = BattleState.PLAYERTURN;
    }

    void PlayerStartOn()
    {
        dialogueText.Enabledialogue(true);
        dialogueText.EnableOthers(true);
        dialogueText.EnableActions(true);
    }

    void PlayerStartOff()
    {
        dialogueText.Enabledialogue(false);
        dialogueText.EnableOthers(false);
        dialogueText.EnableActions(false);
    }

    void PlayerAttackOn()
    {
        dialogueText.EnableAttack(true);
    }

    void PlayerAttackOff()
    {
        dialogueText.EnableAttack(false);
    }

    void PlayerBagOn()
    {
        dialogueText.EnableBag(true);
    }

    void PlayerBagOff()
    {
        dialogueText.EnableBag(false);
    }

    IEnumerator PlayerAttack()
    {
        fireball.Attack();
        bool EnemyisDead = playerUnit.TakeDamage(enemyUnit.damage);



        playerHUD.SetHP(playerUnit.currentHP);

        PlayerAttackOff();
        PlayerStartOn();

        yield return new WaitForSeconds(0.5f);

        if(EnemyisDead)
        {
            state = BattleState.WON;
            monster_alive = false; //這裡

            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {
        bool PlayerisDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyHUD.SetHP(enemyUnit.currentHP);
       
        yield return new WaitForSeconds(1f);

        if(PlayerisDead)
        {
            state = BattleState.LOST;
            EndBattle();
        } else {
            state = BattleState.PLAYERTURN;
            //PlayerTurn();
        }
    }

    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            endNotice.EnableWin(true);
        } else if (state == BattleState.LOST) {
            dialogueText.Enabledialogue(false);
            endNotice.EnableDie(true);
        }
    }

    IEnumerator PlayerHeal()
    {
        enemyUnit.Heal(20);

        enemyHUD.SetHP(enemyUnit.currentHP);

        yield return new WaitForSeconds(0.5f);
        PlayerBagOff();
        PlayerStartOn();
    }

    public void OnAttackButton()
    {
        if(state != BattleState.PLAYERTURN)
            return;

        PlayerStartOff();
        PlayerAttackOn();
    }

    public void OnDefenseButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        PlayerStartOff();
        PlayerAttackOn();
    }

    public void OnBagButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        PlayerStartOff();
        PlayerBagOn();
    }

    public void AttackingButton()
    {
        StartCoroutine(PlayerAttack());
    }

    public void HealingButton()
    {
        StartCoroutine(PlayerHeal());
    }
}
