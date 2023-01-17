using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNPC: MonoBehaviour
{
    [SerializeField]
    private Sprite profileBurguer;
    [SerializeField]
    private Sprite profileClothes;

    private string actorNameBurguer = Texts.msgNameBurguer;
    private string actorNameClothes = Texts.msgNameClothes;

    private Dialogue dialogue;
    private string[] speechTextBurguer = new string[3] { Texts.msgFirstDialogueBurguer, Texts.msgSecondDialogueBurguer, Texts.msgThirdDialogueBurguer };
    private string[] speechTextClothes = new string[3] { Texts.msgFirstDialogueClothes, Texts.msgSecondDialogueClothes, Texts.msgThirdDialogueClothes };


    private void Start()
    {
        dialogue = FindObjectOfType<Dialogue>();
    }

    private void Update()
    {
        if(InferiorButtons.inBurguer)
        {
            Interact(true);
        }   
        
        if(InferiorButtons.inClothes)
        {
            Interact(false);
        }

    }

    public void Interact(bool isBurguer)
    {
        if(isBurguer)
        {
            dialogue.Speech(profileBurguer, speechTextBurguer, actorNameBurguer);
        }
        else
        {
            dialogue.Speech(profileClothes, speechTextClothes, actorNameClothes);
        }   
    }
}
