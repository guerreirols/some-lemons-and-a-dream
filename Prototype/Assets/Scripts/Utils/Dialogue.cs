using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    private GameObject shop;
    [SerializeField]
    private GameObject dialogueBox;
    [SerializeField]
    private Image profile;
    [SerializeField]
    private Text speechText;
    [SerializeField]
    private Text actorNameText;
    [SerializeField]
    private string[] sentences;

    [SerializeField]
    private GameObject yesButtonHamburguer;
    [SerializeField]
    private GameObject yesButtonClothe;

    [SerializeField]
    private float typingSpeed;

    [SerializeField]
    private int index;

    public static bool inDialogue = false;
    
    public void Speech(Sprite profile, string[] text, string actorName)
    {
        dialogueBox.SetActive(true);
        this.profile.sprite = profile;
        this.sentences = text;
        this.actorNameText.text = actorName;
        StartCoroutine(TypeSentence());
        inDialogue = true;
    }

    IEnumerator TypeSentence()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        string currentSentence = null;
        shop.SetActive(false);
        yesButtonHamburguer.SetActive(false);
        yesButtonClothe.SetActive(false);


        if (speechText.text == sentences[index])
        {
            if(index < sentences.Length -1)
            {
                currentSentence = speechText.text;
                index++;
                speechText.text = "";
                StartCoroutine(TypeSentence());
            }
            else
            {
                speechText.text = "";
                yesButtonHamburguer.SetActive(false);
                yesButtonClothe.SetActive(false);
                index = 0;
                dialogueBox.SetActive(false);
                inDialogue = false;
            }
        }

        if (currentSentence == Texts.msgFirstDialogueBurguer || currentSentence == Texts.msgFirstDialogueClothes)
        {
            if(currentSentence == Texts.msgFirstDialogueBurguer)
            {
                yesButtonHamburguer.SetActive(true);
            }
            else
            {
                yesButtonClothe.SetActive(true);
            }         
        }
    }
}
