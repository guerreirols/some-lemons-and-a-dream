using UnityEngine;

public class Product
{
    private int id;
    private string title;
    private Sprite sprite;
    private string description;
    private float price;
    private float power;

    public Product(int id, string title, string description, float price, float power)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.price = price;
        this.power = power;
    }

    public int GetId()
    {
        return id;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    public void SetSprite(Sprite sprite)
    {
        this.sprite = sprite;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public float GetPrice()
    {
        return price;
    }

    public void SetPrice(float price)
    {
        this.price = price;
    }

    public float GetPower()
    {
        return power;
    }

    public void SetPower(float power)
    {
        this.power = power;
    }
}
