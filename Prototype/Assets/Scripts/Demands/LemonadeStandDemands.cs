using UnityEngine;

public class LemonadeStandDemands : MonoBehaviour
{
    private static LemonadeStand lemonadeStand;

    void Start()
    {
        lemonadeStand = new LemonadeStand(2f);
    }

    public static void Sale()
    {
        PlayerDemands.EarnMoney(lemonadeStand.GetLemonadeValue());
    }

    public static LemonadeStand GetLemonadeStand()
    {
        return lemonadeStand;
    }

    public static void MakePremiumLemonades()
    {
        lemonadeStand.SetLemonadeValue(lemonadeStand.GetLemonadeValue() * 2);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag.Equals("Player"))
        {
            lemonadeStand.SetOpen(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            lemonadeStand.SetOpen(false);
        }
    }
}
