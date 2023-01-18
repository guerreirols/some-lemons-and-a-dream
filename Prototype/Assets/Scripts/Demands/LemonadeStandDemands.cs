using UnityEngine;

public class LemonadeStandDemands : MonoBehaviour
{
    private static LemonadeStand lemonadeStand;

    void Awake()
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

    public static void PremiumLemonsStatus(bool buy)
    {
        if(buy)
        {
            lemonadeStand.SetLemonadeValue(4f);
        }
        else
        {
            lemonadeStand.SetLemonadeValue(2f);
        }
    }

    public static void StandTime(int id, bool buy)
    {
        if(buy)
        {
            if (id == 1)
            {
                lemonadeStand.SetLemonadeSpeed(lemonadeStand.GetLemonadeSpeed() - 0.7f);
            }
            else if (id == 2)
            {
                lemonadeStand.SetLemonadeSpeed(lemonadeStand.GetLemonadeSpeed() - 0.9f);
            }
            else if (id == 3)
            {
                lemonadeStand.SetLemonadeSpeed(lemonadeStand.GetLemonadeSpeed() - 1.3f);
            }
        }
        else
        {
            if (id == 1)
            {
                lemonadeStand.SetLemonadeSpeed(lemonadeStand.GetLemonadeSpeed() + 0.7f);
            }
            else if (id == 2)
            {
                lemonadeStand.SetLemonadeSpeed(lemonadeStand.GetLemonadeSpeed() + 0.9f);
            }
            else if (id == 3)
            {
                lemonadeStand.SetLemonadeSpeed(lemonadeStand.GetLemonadeSpeed() + 1.2f);
            }
        }    
    }
}
