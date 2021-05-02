using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, ACTIONS, ATTACK, DEFENSE, BAG, ENEMYTURN, WIN, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public Text levelText;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public DialogueText dialogueText;
    public EndNotice endNotice;
    public AzureSpeech azureSpeech;
    public SpeechLibTest speechLibTest;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public Weapon playerAttack;
    public Weapon enemyAttack;

    public BattleState state;

    public bool click;
    public static bool monster_alive; //這裡

    // Start is called before the first frame update
    // void Awake(){

    // }
    void Start()
    {
        click = false;
        monster_alive = true;
        state = BattleState.START;
        StartCoroutine(SetupBattle());        
    }

    IEnumerator SetupBattle()
    {
        dialogueText.EnableStart(true);
        dialogueText.EnableQuestions(false);
        azureSpeech.EnableAzure(false);
        speechLibTest.EnableSpeech(false);
        dialogueText.EnableBag(false);
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

        state = BattleState.ACTIONS;
    }

    void ActionsOn()
    {
        dialogueText.EnableQuestions(false);
        azureSpeech.EnableAzure(false);
        speechLibTest.EnableSpeech(false);
        dialogueText.EnableStart(true);
    }

    void PlayerAttack()
    {
        playerAttack.Attack();
        playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);
    }

    void EnemyAttack()
    {
        enemyAttack.Attack();
        enemyUnit.TakeDamage(playerUnit.damage);

        enemyHUD.SetHP(enemyUnit.currentHP);
    }

    void DefenseSuccess()
    {
        enemyAttack.Attack();
    }

    void DefenseFail()
    {
        enemyAttack.Attack();
        enemyUnit.DefenseDamage((playerUnit.damage / 2));
        enemyHUD.SetHP(enemyUnit.currentHP);
    }

    void EndBattle()
    {
        if (state == BattleState.WIN)
        {
            endNotice.EnableWin(true);
        }
        else if (state == BattleState.LOST)
        {
            endNotice.EnableDie(true);
        }
    }

    void PlayerHeal()
    {
        enemyUnit.Heal(100);

        enemyHUD.SetHP(enemyUnit.currentHP);

        //yield return new WaitForSeconds(0.5f);

        state = BattleState.ACTIONS;
        dialogueText.EnableBag(false);
        dialogueText.EnableStart(true);
    }

    public void OnAttackButton()
    {
        if(state != BattleState.ACTIONS)
            return;

        state = BattleState.ATTACK;
        dialogueText.EnableStart(false);
        dialogueText.EnableQuestions(true);
        azureSpeech.EnableAzure(true);
        speechLibTest.EnableSpeech(true);
        click = true;
    }

    public void OnDefenseButton()
    {
        if (state != BattleState.ACTIONS)
            return;

        state = BattleState.DEFENSE;
        dialogueText.EnableStart(false);
        dialogueText.EnableQuestions(true);
        azureSpeech.EnableAzure(true);
        speechLibTest.EnableSpeech(true);
        click = true;
    }

    public void OnBagButton()
    {
        if (state != BattleState.ACTIONS)
            return;

        state = BattleState.BAG;
        dialogueText.EnableStart(false);
        dialogueText.EnableBag(true);
    }

    public void HealingButton()
    {
        PlayerHeal();
    }

    void Update()
    {
        bool EnemyIsDead = playerUnit.End();
        bool PlayerIsDead = enemyUnit.End();
        if (click == true)
        {
            if (state == BattleState.ATTACK)
            {
                if (AzureSpeech.message.Contains("奶茶") == true)
                {
                    Invoke("PlayerAttack", 0.5f);
                    //PlayerAttack();

                    state = BattleState.ENEMYTURN;
                    Invoke("EnemyAttack", 1f);

                    state = BattleState.ACTIONS;
                    AzureSpeech.message = "";
                    ActionsOn();

                    click = false;
                }
                else if (AzureSpeech.message.Contains("奶茶") == false & countdown.time == 0)
                {
                    state = BattleState.ENEMYTURN;
                    Invoke("EnemyAttack", 0.5f);
                    //EnemyAttack();

                    state = BattleState.ACTIONS;
                    AzureSpeech.message = "";
                    ActionsOn();

                    click = false;
                }
            }
            else if (state == BattleState.DEFENSE)
            {
                if (AzureSpeech.message.Contains("奶茶") == true)
                {
                    state = BattleState.ENEMYTURN;
                    Invoke("DefenseSuccess", 0.5f);
                    //DefenseSuccess();

                    state = BattleState.ACTIONS;
                    AzureSpeech.message = "";
                    ActionsOn();

                    click = false;
                }
                else if (AzureSpeech.message.Contains("奶茶") == false & countdown.time == 0)
                {
                    state = BattleState.ENEMYTURN;
                    Invoke("DefenseFail", 0.5f);
                    //DefenseFail();

                    state = BattleState.ACTIONS;
                    AzureSpeech.message = "";
                    ActionsOn();

                    click = false;
                }
            }
            //else if (state == BattleState.BAG)
            //{
            //    PlayerHeal();

            //    state = BattleState.ACTIONS;
            //    dialogueText.EnableBag(false);
            //    dialogueText.EnableStart(true);

            //    click = false;
            //}
        }
        if (PlayerIsDead == true)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        if (EnemyIsDead == true)
        {
            monster_alive = false;
            state = BattleState.WIN;
            EndBattle();
        }
    }
}
