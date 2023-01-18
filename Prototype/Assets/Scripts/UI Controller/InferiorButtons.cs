using UnityEngine;
using UnityEngine.UI;

public class InferiorButtons : MonoBehaviour
{
    [SerializeField]
    private Animator manageStandAnimator;
    [SerializeField]
    private Animator interactBurguer;
    [SerializeField]
    private Animator interactClothe;

    [SerializeField]
    private Text clothesBag;
    [SerializeField]
    private Text manageStand;
    [SerializeField]
    private Text interact;

    [SerializeField]
    private GameObject canvasManageStore;
    [SerializeField]
    private GameObject canvasClothesBag;

    public static bool inBurguer;
    public static bool inClothes;

    void Start()
    {
        clothesBag.text = Texts.msgClothesBag;
        manageStand.text = Texts.msgManageStand;
        interact.text = Texts.msgInteract;
    }

    
    void Update()
    {
        if(!LemonadeStandDemands.GetLemonadeStand().GetOpen())
        {
            manageStandAnimator.SetBool("hideButton", true);      
        }
        else
        {
            manageStandAnimator.SetBool("hideButton", false);
            if (Input.GetKeyDown(KeyCode.L))
            {
                OpenManageStand();
            }
        }

        //

        if (!TopBurguerTrigger.topBurguerTrigger)
        {
            interactBurguer.SetBool("hideButton", true);
        }
        else
        {
            interactBurguer.SetBool("hideButton", false);
            if (Input.GetKeyDown(KeyCode.I) && !Dialogue.inDialogue)
            {
                inBurguer = true;
            }
            else
            {
                inBurguer = false;
            }
        }

        // 

        if (!TopClothesTrigger.topClothesTrigger)
        {
            interactClothe.SetBool("hideButton", true);
        }
        else
        {
            interactClothe.SetBool("hideButton", false);
            if (Input.GetKeyDown(KeyCode.I) && !Dialogue.inDialogue)
            {
                inClothes = true;
            }
            else
            {
                inClothes = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            OpenClothesBag();
        }
    }

    public void OpenManageStand()
    {
        canvasManageStore.SetActive(true);
    }

    public void ExitManageStand()
    {
        canvasManageStore.SetActive(false); 
    }

    public void OpenClothesBag()
    {
        canvasClothesBag.SetActive(true);
    }

    public void ExitClothesBag()
    {
        canvasClothesBag.SetActive(false);
    }


}
