using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField]
    private Image clotheDesireBar;
    [SerializeField]
    private Image hungryBar;
    [SerializeField]
    private Text money;
    [SerializeField]
    private Text mood;

    void Update()
    {
        clotheDesireBar.fillAmount = PlayerDemands.GetPlayer().GetClothesDesire();
        hungryBar.fillAmount = PlayerDemands.GetPlayer().GetHungry();
        money.text = "M$: " + PlayerDemands.GetPlayer().GetMoney().ToString("N");
        mood.text = PlayerDemands.GetPlayer().GetIsHappy() ? Texts.msgHappy : Texts.msgAngry;
    }
}
