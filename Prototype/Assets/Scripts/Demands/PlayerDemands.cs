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

        if (player.GetHungry() >= 1f)
        {
            player.SetHungry(1f);
        }
    }

    public static void KillHungry(float power)
    {
        player.SetHungry(player.GetHungry() - power);

        if(player.GetHungry() <= 0)
        {
            player.SetHungry(0);
        }
    }

    public static void ClothesDesire()
    {
        player.SetClothesDesire(player.GetClothesDesire() + 0.1f);

        if (player.GetClothesDesire() >= 1f)
        {
            player.SetClothesDesire(1f);
        }
    }

    public static void KillClothesDesire(float power)
    {
        player.SetClothesDesire(player.GetClothesDesire() - 3);

        if (player.GetClothesDesire() <= 0)
        {
            player.SetClothesDesire(0);
        }
    }

    public static void MoodSensor()
    {
        if (player.GetHungry() == 1f || player.GetClothesDesire() == 1f)
        {
            player.SetIsHappy(false);
        }
        else
        {
            player.SetIsHappy(true);
        }
    }
}
