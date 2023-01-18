using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurguerAndClothesShop : MonoBehaviour
{
    [SerializeField]
    private GameObject shop;
    [SerializeField]
    private GameObject basicSold;
    [SerializeField]
    private GameObject superSold;
    [SerializeField]
    private Text title;
    [SerializeField]
    private Text money;

    [SerializeField]
    private Text titleBasicCard;
    [SerializeField]
    private Image imageBasicCard;
    [SerializeField]
    private Text descriptionBasicCard;
    [SerializeField]
    private Text priceBasicCard;

    [SerializeField]
    private Text titleSuperCard;
    [SerializeField]
    private Image imageSuperCard;
    [SerializeField]
    private Text descriptionSuperCard;
    [SerializeField]
    private Text priceSuperCard;

    private Product basicProduct;
    private Product superProduct;

    [SerializeField]
    private Sprite happyHamburguerSprite;
    [SerializeField]
    private Sprite monsterHamburguerSprite;
    [SerializeField]
    private Sprite boybandShirtSprite;
    [SerializeField]
    private Sprite bikerJacketSprite;

    [SerializeField]
    private Button basicButton;
    [SerializeField]
    private Button superButton;

    private bool isBurguer;

    public void OpenShop(bool isBurguer)
    {
        this.isBurguer = isBurguer;

        shop.SetActive(true);
        basicSold.SetActive(false);
        superSold.SetActive(false);

        money.text = "M$ " + PlayerDemands.GetPlayer().GetMoney().ToString("N");

        if (isBurguer)
        {
            basicProduct = ProductsShopDemand.GetBasicHamburguer();
            superProduct = ProductsShopDemand.GetSuperHamburguer();

            title.text = Texts.msgShopHamburguerTitle;
            titleBasicCard.text = basicProduct.GetTitle();
            imageBasicCard.sprite = happyHamburguerSprite;
            descriptionBasicCard.text = basicProduct.GetDescription();
            priceBasicCard.text = basicProduct.GetPrice().ToString("N");

            titleSuperCard.text = superProduct.GetTitle();
            imageSuperCard.sprite = monsterHamburguerSprite;
            descriptionSuperCard.text = superProduct.GetDescription();
            priceSuperCard.text = superProduct.GetPrice().ToString("N");
        }
        else
        {
            basicProduct = ProductsShopDemand.GetBasicClothe();
            superProduct = ProductsShopDemand.GetSuperClothe();

            title.text = Texts.msgShopClothesTitle;
            titleBasicCard.text = basicProduct.GetTitle();
            imageBasicCard.sprite = boybandShirtSprite;
            descriptionBasicCard.text = basicProduct.GetDescription();
            priceBasicCard.text = basicProduct.GetPrice().ToString("N");

            titleSuperCard.text = superProduct.GetTitle();
            imageSuperCard.sprite = bikerJacketSprite;
            descriptionSuperCard.text = superProduct.GetDescription();
            priceSuperCard.text = superProduct.GetPrice().ToString("N");
        }

        if (basicProduct.GetPrice() > PlayerDemands.GetPlayer().GetMoney())
        {
            basicButton.interactable = false;
        }
        else
        {
            basicButton.interactable = true;
        }

        if (superProduct.GetPrice() > PlayerDemands.GetPlayer().GetMoney())
        {
            superButton.interactable = false;
        }
        else
        {
            superButton.interactable = true;
        }

        //

        if (basicProduct.GetId() == 3 && PlayerDemands.GetPlayer().GetClothesBag().GetHasBasicShirt())
        {
            basicSold.SetActive(true);
            basicButton.interactable = false;
        }

        if (superProduct.GetId() == 4 && PlayerDemands.GetPlayer().GetClothesBag().GetHasSuperShirt())
        {
            superSold.SetActive(true);
            superButton.interactable = false;
        }
    }

    public void BuyProduct(int id)
    {
        if(isBurguer)
        {
            if(id == 1)
            {
                PlayerDemands.KillHungry(basicProduct.GetPower());
                PlayerDemands.Buy(basicProduct.GetPrice());
            }
            else
            {
                PlayerDemands.KillHungry(superProduct.GetPower());
                PlayerDemands.Buy(superProduct.GetPrice());
            }
        } 
        else
        {
            if (id == 1)
            {
                PlayerDemands.KillClothesDesire(basicProduct.GetPower());
                PlayerDemands.Buy(basicProduct.GetPrice());
                PlayerDemands.GetPlayer().GetClothesBag().SetHasBasicShirt(true);
            }
            else
            {
                PlayerDemands.KillClothesDesire(superProduct.GetPower());
                PlayerDemands.Buy(superProduct.GetPrice());
                PlayerDemands.GetPlayer().GetClothesBag().SetHasSuperShirt(true);
            }
        }

        //

        if (basicProduct.GetId() == 3 && PlayerDemands.GetPlayer().GetClothesBag().GetHasBasicShirt())
        {
            basicSold.SetActive(true);
            basicButton.interactable = false;
        }

        if (superProduct.GetId() == 4 && PlayerDemands.GetPlayer().GetClothesBag().GetHasSuperShirt())
        {
            superSold.SetActive(true);
            superButton.interactable = false;
        }

        money.text = "M$ " + PlayerDemands.GetPlayer().GetMoney().ToString("N");
    }
}
