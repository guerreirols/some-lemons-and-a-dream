using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClothe : MonoBehaviour
{
    public static int idClothe;

    [SerializeField]
    private Skins[] skins;
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();     
    }

    void Update()
    {
        if(idClothe > skins.Length -1)
        {
            idClothe = 0;
        }
        else if(idClothe < 0)
        {
            idClothe = skins.Length - 1;
        }
    }

    void LateUpdate()
    {
        SkinChoice();
    }

    void SkinChoice()
    {
        if(spriteRenderer.sprite.name.Contains("player"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("player_", "");
            int spriteNum = int.Parse(spriteName);

            spriteRenderer.sprite = skins[idClothe].sprites[spriteNum];
        }
    }
}

[System.Serializable]
public struct Skins
{
    public Sprite[] sprites;
}
