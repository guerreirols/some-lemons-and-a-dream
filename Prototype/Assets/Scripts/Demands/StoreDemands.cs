using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreDemands : MonoBehaviour
{
    private static StoreCard bowl;
    private static StoreCard blender;
    private static StoreCard superBlender;
    private static StoreCard premiumLemons;

    private static List<StoreCard> storeCardsList = new List<StoreCard>();
    private static List<YourItem> yourItemsList = new List<YourItem>();

    void Awake()
    {
        bowl = new StoreCard(1, Texts.msgCardBowlTitle, Texts.msgCardBowlDescription, 10f);
        blender = new StoreCard(2, Texts.msgCardBlenderTitle, Texts.msgCardBlenderDescription, 20f);
        superBlender = new StoreCard(3, Texts.msgCardSuperBlenderTitle, Texts.msgCardSuperBlenderDescription, 30f);
        premiumLemons = new StoreCard(4, Texts.msgCardPremiumLemonsTitle, Texts.msgCardPremiumLemonsDescription, 60f);

        storeCardsList.Add(bowl);
        storeCardsList.Add(blender);
        storeCardsList.Add(superBlender);
        storeCardsList.Add(premiumLemons);
    }

    public static StoreCard GetCardBowl()
    {
        return bowl;
    }

    public static StoreCard GetCardBlender()
    {
        return blender;
    }

    public static StoreCard GetCardSuperBlender()
    {
        return superBlender;
    }

    public static StoreCard GetCardPremiumLemons()
    {
        return premiumLemons;
    }
    
    public static List<YourItem> GetYourItemsList()
    {
        return yourItemsList;
    }

    public static List<StoreCard> GetStoreCardList()
    {
        return storeCardsList;
    }

    private static StoreCard FindStoreCardById(int id)
    {
        StoreCard storeCard = null;

        for(int i = 0; i < storeCardsList.Count; i++)
        {
            if (storeCardsList[i].GetId() == id)
            {
                storeCard = storeCardsList[i];
            }
        }

        return storeCard;    
    }

    public static YourItem BuyItem(int id)
    {
        bool hasItem = false;

        YourItem yourItem = new YourItem(0, FindStoreCardById(id));

        foreach(YourItem item in yourItemsList)
        {
            if(item.GetStoreCard().GetId() == id)
            {              
                yourItem = item;
                hasItem = true;
            }
        }

        if(!hasItem)
        {
            yourItemsList.Add(yourItem);
        }

        PlayerDemands.Buy(yourItem.GetStoreCard().GetPrice());

        switch (yourItem.GetStoreCard().GetId())
        {
            case 1:
                LemonadeStandDemands.GetLemonadeStand().SetBowls(LemonadeStandDemands.GetLemonadeStand().GetBowls() + 1);
                LemonadeStandDemands.GetLemonadeStand().SetTotalBlenders(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders() + 1);
                break;
            case 2:
                print("a");
                LemonadeStandDemands.GetLemonadeStand().SetBasicBlenders(LemonadeStandDemands.GetLemonadeStand().GetBasicBlenders() + 1);
                LemonadeStandDemands.GetLemonadeStand().SetTotalBlenders(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders() + 1);
                print(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders());
                break;
            case 3:
                LemonadeStandDemands.GetLemonadeStand().SetSuperBlenders(LemonadeStandDemands.GetLemonadeStand().GetSuperBlenders() + 1);
                LemonadeStandDemands.GetLemonadeStand().SetTotalBlenders(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders() + 1);
                break;
            case 4:
                LemonadeStandDemands.GetLemonadeStand().SetPremiumLemons(true);
                break;
        }

        return yourItem;
    }

    public static void SellItem(StoreCard storeCard)
    {
        PlayerDemands.EarnMoney(storeCard.GetPrice());

        switch (storeCard.GetId())
        {
            case 1:
                LemonadeStandDemands.GetLemonadeStand().SetBowls(LemonadeStandDemands.GetLemonadeStand().GetBowls() - 1);
                LemonadeStandDemands.GetLemonadeStand().SetTotalBlenders(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders() - 1);
                break;
            case 2:
                LemonadeStandDemands.GetLemonadeStand().SetBasicBlenders(LemonadeStandDemands.GetLemonadeStand().GetBasicBlenders() - 1);
                LemonadeStandDemands.GetLemonadeStand().SetTotalBlenders(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders() - 1);
                break;
            case 3:
                LemonadeStandDemands.GetLemonadeStand().SetSuperBlenders(LemonadeStandDemands.GetLemonadeStand().GetSuperBlenders() - 1);
                LemonadeStandDemands.GetLemonadeStand().SetTotalBlenders(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders() - 1);
                break;
            case 4:
                LemonadeStandDemands.GetLemonadeStand().SetPremiumLemons(false);
                break;
        }
    }




}
