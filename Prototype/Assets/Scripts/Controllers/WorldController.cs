using System.Collections;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    private bool gameOver;

    void Start()
    {
        StartCoroutine(SoldLemonade());
        StartCoroutine(Hungry());
        StartCoroutine(ClotheDesire());
    }

    void Update()
    {
        PlayerDemands.MoodSensor();
    }

    IEnumerator SoldLemonade()
    {
        while(!gameOver)
        {
            yield return new WaitForSeconds(2f);
            if (LemonadeStandDemands.GetLemonadeStand().GetOpen())
            {
                LemonadeStandDemands.Sale();
            }            
        }  
    }

    IEnumerator Hungry()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(8f);
            PlayerDemands.Hungry();
        }
    }
    IEnumerator ClotheDesire()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(1f);
            PlayerDemands.ClothesDesire();
        }
    }

}
