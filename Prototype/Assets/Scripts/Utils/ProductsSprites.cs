using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsSprites : MonoBehaviour
{
    [SerializeField]
    private Sprite basicHamburguerSprite;
    [SerializeField]
    private Sprite superHamburguerSprite;
    [SerializeField]
    private Sprite basicClotheSprite;
    [SerializeField]
    private Sprite superClotheSprite;

    static Sprite a;

    void Update()
    {
        superClotheSprite = a;
    }


}
