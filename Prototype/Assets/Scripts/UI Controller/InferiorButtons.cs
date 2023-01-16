using UnityEngine;
using UnityEngine.UI;

public class InferiorButtons : MonoBehaviour
{
    [SerializeField]
    private Animator manageStandAnimator;

    [SerializeField]
    private Text clothesBag;
    [SerializeField]
    private Text manageStand;
    [SerializeField]
    private Text interact;

    [SerializeField]
    private GameObject canvasManageStore;

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


    }

    public void OpenManageStand()
    {
        canvasManageStore.SetActive(true);
    }

    public void ExitManageStand()
    {
        canvasManageStore.SetActive(false); 
    }
}
