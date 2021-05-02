using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText : MonoBehaviour
{
    public int lettersPerSecond;
    public Text dialogueText;

    public GameObject actions;
    public GameObject questions;
    public GameObject bag;

    public void SetDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }

    public IEnumerator TypeDialogue(string dialogue)
    {
        dialogueText.text = "";
        foreach (var letter in dialogue.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }
    }

    public void EnableStart(bool enabled)
    {
        dialogueText.enabled = enabled;
        actions.SetActive(enabled);
    }

    public void EnableQuestions(bool enabled)
    {
        questions.SetActive(enabled);
    }

    public void EnableBag(bool enabled)
    {
        bag.SetActive(enabled);
    }
}