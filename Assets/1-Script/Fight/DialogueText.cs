using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText : MonoBehaviour
{
    public int lettersPerSecond;
    public Text dialogueText;

    public GameObject others;
    public GameObject actions;
    public GameObject turnAttack;
    public GameObject turnBag;

    public void SetDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }

    public IEnumerator TypeDialogue(string dialogue)
    {
        dialogueText.text = "";
        foreach(var letter in dialogue.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(1f/lettersPerSecond);
        }
    }

    public void Enabledialogue(bool enabled)
    {
        dialogueText.enabled = enabled;
    }

    public void EnableOthers(bool enabled)
    {
        others.SetActive(enabled);
    }

    public void EnableActions(bool enabled)
    {
        actions.SetActive(enabled);
    }

    public void EnableAttack(bool enabled)
    {
        turnAttack.SetActive(enabled);
    }

    public void EnableBag(bool enabled)
    {
        turnBag.SetActive(enabled);
    }
}
