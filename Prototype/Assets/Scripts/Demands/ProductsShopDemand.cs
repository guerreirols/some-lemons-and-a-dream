using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsShopDemand : MonoBehaviour
{
    private static Product basicHamburguer;
    private static Product superHamburguer;
    private static Product basicClothe;
    private static Product superClothe;

    private static List<Product> productsList = new List<Product>();

    void Awake()
    {
        basicHamburguer = new Product(1, Texts.msgBasicHamburguer, Texts.msgBasicHamburguerDescription, 10f, 0.3f);
        superHamburguer = new Product(2, Texts.msgSuperHamburguer, Texts.msgSuperHamburguerDescription, 30f, 1f);

        basicClothe = new Product(3, Texts.msgBasicClothe, Texts.msgBasicClotheDescription, 10f, 0.3f);
        superClothe = new Product(4, Texts.msgSuperClothe, Texts.msgSuperClotheDescription, 60f, 0.8f);
    }

    public static Product FindProductById(int id)
    {
        Product product = null;

        for (int i = 0; i < productsList.Count; i++)
        {
            if (productsList[i].GetId() == id)
            {
                product = productsList[i];
            }
        }

        return product;
    }

    public static Product GetBasicHamburguer()
    {
        return basicHamburguer;
    }

    public static Product GetSuperHamburguer()
    {
        return superHamburguer;
    }

    public static Product GetBasicClothe()
    {
        return basicClothe;
    }

    public static Product GetSuperClothe()
    {
        return superClothe;
    }
}
