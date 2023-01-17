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

        }
        else if(id == 2)
        {

        }
        else
        {

        }
    }
}
