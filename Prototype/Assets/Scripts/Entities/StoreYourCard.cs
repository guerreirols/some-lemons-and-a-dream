using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreYourCard 
{
    private bool activeObject;
    private string title;
    private Image image;
    private int quantity;
    private string sellButtonText;

    public StoreYourCard(string title, Image image)
    {
        this.title = title;
        this.image = image;
        this.quantity = 0;
        this.sellButtonText = Texts.msgSellButton;
    }

    public bool GetAtiveObject()
    {
        return activeObject;
    }

    public void SetAtiveObject(bool activeObject)
    {
        this.activeObject = activeObject;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public Image GetImage()
    {
        return image;
    }

    public void SetImage(Image image)
    {
        this.image = image;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public string GetSellButtonText()
    {
        return sellButtonText;
    }
}
