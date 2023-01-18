using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClotheBag : MonoBehaviour
{
    [SerializeField]
    private GameObject classic;
    [SerializeField]
    private GameObject super;

    public void Update()
    {
        if(PlayerDemands.GetPlayer().GetClothesBag().GetHasBasicShirt())
        {
            classic.SetActive(true);
        }

        if(PlayerDemands.GetPlayer().GetClothesBag().GetHasSuperShirt())
        {
            super.SetActive(true);
        }
    }

    public void Wear(int id)
    {
        if(id == 1)
        {
            ChangeClothe.idClothe = 1;
            PlayerDemands.KillClothesDesire(3f);
        }
        else if(id == 2)
        {
            ChangeClothe.idClothe = 2;
            PlayerDemands.KillClothesDesire(8f);
        }
        else
        {
            ChangeClothe.idClothe = 0;
            PlayerDemands.KillClothesDesire(1f);
        }
    }
}
