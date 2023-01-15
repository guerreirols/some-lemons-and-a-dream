using UnityEngine;

public class PlayerDemands : MonoBehaviour
{
    private static Player player;

    void Start()
    {
        player = new Player();
    }

    public static Player GetPlayer()
    {
        return player;
    }

    public static void Buy(float value)
    {
        player.SetMoney(player.GetMoney() - value);
    }

    public static void EarnMoney(float value)
    {
        player.SetMoney(player.GetMoney() + value);
    }

    public static void Hungry()
    {
        player.SetHungry(player.GetHungry() + 0.1f);
    }

    public static void KillHungry(int idHamburguer)
    {
        if(idHamburguer == 1)
        {
            player.SetHungry(player.GetHungry() - 3);
        }
        else
        {
            player.SetHungry(player.GetHungry() - 5);
        }
    }

    public static void ClothesDesire()
    {
        player.SetClothesDesire(player.GetClothesDesire() + 0.1f);
    }

    public static void KillClothesDesire(int idClothe)
    {
        if (idClothe == 1)
        {
            player.SetClothesDesire(player.GetClothesDesire() - 3);
        }
        else
        {
            player.SetClothesDesire(player.GetClothesDesire() - 5);
        }
    }

    public static void MoodSensor()
    {
        if (player.GetHungry() > 1f || player.GetClothesDesire() > 1f)
        {
            player.SetIsHappy(false);
        }
        else
        {
            player.SetIsHappy(true);
        }
    }
}
