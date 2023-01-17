using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WorldController : MonoBehaviour
{
    private bool gameOver;


    [SerializeField]
    private Image mood;

    [SerializeField]
    private Sprite happy;
    [SerializeField]
    private Sprite angry;

    void Start()
    {
        StartCoroutine(SoldLemonade());
        StartCoroutine(Hungry());
        StartCoroutine(ClotheDesire());
    }

    void Update()
    {
        PlayerDemands.MoodSensor();

        if(PlayerDemands.GetPlayer().GetIsHappy())
        {
            mood.sprite = happy;
        }
        else
        {
            mood.sprite = angry;
        }
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
