using UnityEngine;

public class StoreCard
{
    private int id;
    private string title;
    private string description;
    private float price;

    public StoreCard(int id, string title, string description, float price)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.price = price;
    }

    public int GetId()
    {
        return id;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetDescription()
    {
        return description;
    }

    public float GetPrice()
    {
        return price;
    }

}
