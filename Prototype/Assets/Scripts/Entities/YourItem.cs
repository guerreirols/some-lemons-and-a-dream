using UnityEngine;

public class YourItem
{
    private int quantity;
    private StoreCard storeCard;

    public YourItem(int quantity, StoreCard storeCard)
    {
        this.quantity = quantity;
        this.storeCard = storeCard;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public StoreCard GetStoreCard()
    {
        return storeCard;
    }

}
