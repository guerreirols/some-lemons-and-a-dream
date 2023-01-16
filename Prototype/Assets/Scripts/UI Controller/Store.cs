using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [SerializeField]
    private Text money;

    [SerializeField]
    private Text titleBowl;
    [SerializeField]
    private Image imageBowl;
    [SerializeField]
    private Text descriptionBowl;
    [SerializeField]
    private Text priceBowl;
    [SerializeField]
    private Button buttonBowl;

    [SerializeField]
    private Text titleBlender;
    [SerializeField]
    private Image imageBlender;
    [SerializeField]
    private Text descriptionBlender;
    [SerializeField]
    private Text priceBlender;
    [SerializeField]
    private Button buttonBlender;

    [SerializeField]
    private Text titleSuperBlender;
    [SerializeField]
    private Image imageSuperBlender;
    [SerializeField]
    private Text descriptionSuperBlender;
    [SerializeField]
    private Text priceSuperBlender;
    [SerializeField]
    private Button buttonSuperBlender;

    [SerializeField]
    private Text titlePremiumLemons;
    [SerializeField]
    private Image imagePremiumLemons;
    [SerializeField]
    private Text descriptionPremiumLemons;
    [SerializeField]
    private Text pricePremiumLemons;
    [SerializeField]
    private Button buttonPremiumLemons;

    [SerializeField]
    private GameObject cardObject1;
    [SerializeField]
    private Text cardTitle1;
    [SerializeField]
    private Image cardImage1;
    [SerializeField]
    private Text cardQuantity1;

    [SerializeField]
    private GameObject cardObject2;
    [SerializeField]
    private Text cardTitle2;
    [SerializeField]
    private Image cardImage2;
    [SerializeField]
    private Text cardQuantity2;

    [SerializeField]
    private GameObject cardObject3;
    [SerializeField]
    private Text cardTitle3;
    [SerializeField]
    private Image cardImage3;
    [SerializeField]
    private Text cardQuantity3;

    [SerializeField]
    private GameObject cardObject4;
    [SerializeField]
    private Text cardTitle4;
    [SerializeField]
    private Image cardImage4;
    [SerializeField]
    private Text cardQuantity4;

    private StoreYourCard yourBowlCard;
    private StoreYourCard yourBlenderCard;
    private StoreYourCard yourSuperBlenderCard;
    private StoreYourCard yourPremiumLemonsCard;

    private static List<StoreYourCard> storeCardsYourList = new List<StoreYourCard>();

    void Start()
    {
        CreateCards();
        CreateYourCards();
    }

    void Update()
    {
        money.text = "M$: " + PlayerDemands.GetPlayer().GetMoney().ToString("N");
        CanBuy();
    }

    void CreateCards()
    {
        titleBowl.text = StoreDemands.GetCardBowl().GetTitle();
        descriptionBowl.text = StoreDemands.GetCardBowl().GetDescription();
        priceBowl.text = "M$: " + StoreDemands.GetCardBowl().GetPrice().ToString("N");

        titleBlender.text = StoreDemands.GetCardBlender().GetTitle();
        descriptionBlender.text = StoreDemands.GetCardBlender().GetDescription();
        priceBlender.text = "M$: " + StoreDemands.GetCardBlender().GetPrice().ToString("N");

        titleSuperBlender.text = StoreDemands.GetCardSuperBlender().GetTitle();
        descriptionSuperBlender.text = StoreDemands.GetCardSuperBlender().GetDescription();
        priceSuperBlender.text = "M$: " + StoreDemands.GetCardSuperBlender().GetPrice().ToString("N");

        titlePremiumLemons.text = StoreDemands.GetCardPremiumLemons().GetTitle();
        descriptionPremiumLemons.text = StoreDemands.GetCardPremiumLemons().GetDescription();
        pricePremiumLemons.text = "M$: " + StoreDemands.GetCardPremiumLemons().GetPrice().ToString("N");
    }

    void CreateYourCards()
    {
        storeCardsYourList.Add(yourBowlCard = new StoreYourCard(StoreDemands.GetCardBowl().GetTitle(), imageBowl));
        storeCardsYourList.Add(yourBlenderCard = new StoreYourCard(StoreDemands.GetCardBlender().GetTitle(), imageBlender));
        storeCardsYourList.Add(yourSuperBlenderCard = new StoreYourCard(StoreDemands.GetCardSuperBlender().GetTitle(), imageSuperBlender));
        storeCardsYourList.Add(yourPremiumLemonsCard = new StoreYourCard(StoreDemands.GetCardPremiumLemons().GetTitle(), imagePremiumLemons));    
    }

    private void CanBuy()
    {
        if(LemonadeStandDemands.GetLemonadeStand().GetTotalBlenders() < 4)
        {
            if (StoreDemands.GetCardBowl().GetPrice() > PlayerDemands.GetPlayer().GetMoney())
            {
                buttonBowl.interactable = false;
            }
            else
            {
                buttonBowl.interactable = true;
            }

            //

            if (StoreDemands.GetCardBlender().GetPrice() > PlayerDemands.GetPlayer().GetMoney())
            {
                buttonBlender.interactable = false;
            }
            else
            {
                buttonBlender.interactable = true;
            }

            //

            if (StoreDemands.GetCardSuperBlender().GetPrice() > PlayerDemands.GetPlayer().GetMoney())
            {
                buttonSuperBlender.interactable = false;
            }
            else
            {
                buttonSuperBlender.interactable = true;
            }
        }
        else
        {
            buttonBowl.interactable = false;
            buttonBlender.interactable = false;
            buttonSuperBlender.interactable = false;
        }

        //

        if(LemonadeStandDemands.GetLemonadeStand().GetPremiumLemons() == false 
            && StoreDemands.GetCardPremiumLemons().GetPrice() < PlayerDemands.GetPlayer().GetMoney())
        {
            buttonPremiumLemons.interactable = true;
        }
        else
        {
            buttonPremiumLemons.interactable = false;
        }


    }

    public void Buy(int id)
    {
        YourItem yourItem = StoreDemands.BuyItem(id);

        bool hasItem = false;

        foreach(StoreYourCard storeYourCard in storeCardsYourList)
        {
            if(storeYourCard.GetTitle().Equals(yourItem.GetStoreCard().GetTitle()))
            {
                if(!cardTitle1.text.Equals(storeYourCard.GetTitle()) && !cardTitle2.text.Equals(storeYourCard.GetTitle())
                    && !cardTitle3.text.Equals(storeYourCard.GetTitle()) && !cardTitle4.text.Equals(storeYourCard.GetTitle()))
                {
                    storeYourCard.SetQuantity(storeYourCard.GetQuantity() + 1);

                    if (cardTitle1.text.Equals("empty"))
                    {
                        cardObject1.SetActive(true);
                        cardTitle1.text = storeYourCard.GetTitle();
                        cardImage1.sprite = storeYourCard.GetImage().sprite;
                        cardQuantity1.text = storeYourCard.GetQuantity() + "x";
                    }
                    else if (cardTitle2.text.Equals("empty"))
                    {
                        cardObject2.SetActive(true);
                        cardTitle2.text = storeYourCard.GetTitle();
                        cardImage2.sprite = storeYourCard.GetImage().sprite;
                        cardQuantity2.text = storeYourCard.GetQuantity() + "x";
                    }
                    else if (cardTitle3.text.Equals("empty"))
                    {
                        cardObject3.SetActive(true);
                        cardTitle3.text = storeYourCard.GetTitle();
                        cardImage3.sprite = storeYourCard.GetImage().sprite;
                        cardQuantity3.text = storeYourCard.GetQuantity() + "x";
                    }
                    else if (cardTitle4.text.Equals("empty"))
                    {
                        cardObject4.SetActive(true);
                        cardTitle4.text = storeYourCard.GetTitle();
                        cardImage4.sprite = storeYourCard.GetImage().sprite;
                        cardQuantity4.text = storeYourCard.GetQuantity() + "x";
                    }
                }
                else
                {
                    hasItem = true;
                }               
            }
        }

        if(hasItem)
        {
            foreach (StoreYourCard storeYourCard in storeCardsYourList)
            {
                if (storeYourCard.GetTitle().Equals(yourItem.GetStoreCard().GetTitle()))
                {
                    storeYourCard.SetQuantity(storeYourCard.GetQuantity() + 1);
                    print("veio");

                    if (cardTitle1.text.Equals(storeYourCard.GetTitle()))
                    {
                        cardQuantity1.text = storeYourCard.GetQuantity() + "x";
                    }
                    else if (cardTitle2.text.Equals(storeYourCard.GetTitle()))
                    {
                        cardQuantity2.text = storeYourCard.GetQuantity() + "x";
                    }
                    else if (cardTitle3.text.Equals(storeYourCard.GetTitle()))
                    {
                        cardQuantity3.text = storeYourCard.GetQuantity() + "x";
                    }
                    else if (cardTitle4.text.Equals(storeYourCard.GetTitle()))
                    {
                        cardQuantity4.text = storeYourCard.GetQuantity() + "x";
                    }
                }
            }
        }      
    }

    public void Sell(int card)
    {
        string itemSold = null;

        switch (card)
        {
            case 1:
                itemSold = cardTitle1.text;
                break;
            case 2:
                itemSold = cardTitle2.text;
                break;
            case 3:
                itemSold = cardTitle3.text;
                break;
            case 4:
                itemSold = cardTitle4.text;
                break;
        }

        foreach (StoreYourCard storeYourCard in storeCardsYourList)
        {
            if (storeYourCard.GetTitle().Equals(itemSold))
            {
                storeYourCard.SetQuantity(storeYourCard.GetQuantity() -1);

                switch (card)
                {
                    case 1:
                        if(storeYourCard.GetQuantity() < 1)
                        {
                            cardTitle1.text = "empty";
                            cardImage1.sprite = cardImage2.sprite;
                            cardQuantity1.text = cardQuantity2.text;
                            cardTitle1.text = cardTitle2.text;
                            cardImage2.sprite = cardImage3.sprite;
                            cardQuantity2.text = cardQuantity3.text;
                            cardTitle2.text = cardTitle3.text;
                            cardImage3.sprite = cardImage4.sprite;
                            cardQuantity3.text = cardQuantity4.text;
                            cardTitle3.text = cardTitle4.text;
                            cardTitle4.text = "empty";
                        } 
                        else
                        {
                            cardQuantity1.text = storeYourCard.GetQuantity() + "x";
                        }
                        break;
                    case 2:
                        if (storeYourCard.GetQuantity() < 1)
                        {
                            cardTitle2.text = "empty";
                            cardImage2.sprite = cardImage3.sprite;
                            cardQuantity2.text = cardQuantity3.text;
                            cardTitle2.text = cardTitle3.text;
                            cardImage3.sprite = cardImage4.sprite;
                            cardQuantity3.text = cardQuantity4.text;
                            cardTitle3.text = cardTitle4.text;
                            cardTitle4.text = "empty";
                        }
                        else
                        {
                            cardQuantity2.text = storeYourCard.GetQuantity() + "x";
                        }
                        break;
                    case 3:
                        if (storeYourCard.GetQuantity() < 1)
                        {
                            cardTitle3.text = "empty";
                            cardImage3.sprite = cardImage4.sprite;
                            cardQuantity3.text = cardQuantity4.text;
                            cardTitle3.text = cardTitle4.text;
                            cardTitle4.text = "empty";
                        }
                        else
                        {
                            cardQuantity3.text = storeYourCard.GetQuantity() + "x";
                        }
                        break;
                    case 4:
                        if (storeYourCard.GetQuantity() < 1)
                        {
                            cardTitle4.text = "empty";
                        }
                        else
                        {
                            cardQuantity4.text = storeYourCard.GetQuantity() + "x";
                        }
                        break;
                }
            }
        }

        if (cardTitle1.text == "empty")
        {
            cardObject1.SetActive(false);
        }
        else if(cardTitle2.text == "empty")
        {
            cardObject2.SetActive(false);
        }
        else if (cardTitle3.text == "empty")
        {
            cardObject3.SetActive(false);
        }
        else if (cardTitle4.text == "empty")
        {
            cardObject4.SetActive(false);
        }

        foreach (StoreCard storeCard in StoreDemands.GetStoreCardList())
        {
            if(storeCard.GetTitle().Equals(itemSold))
            {
                StoreDemands.SellItem(storeCard);
            }
        }
    }
}
