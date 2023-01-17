public class Player
{
    private float clothesDesire;
    private float hungry;
    private float money;
    private bool isHappy;
    private ClothesBag clothesBag;

    public Player()
    {
        clothesDesire = 0f;
        hungry = 0f;
        money = 200f;
        isHappy = true;
        clothesBag = new ClothesBag();
    }

    public float GetClothesDesire()
    {
        return clothesDesire;
    }

    public void SetClothesDesire(float clothesDesire)
    {
        this.clothesDesire = clothesDesire;
    }

    public float GetHungry()
    {
        return hungry;
    }

    public void SetHungry(float hungry)
    {
        this.hungry = hungry;
    }

    public float GetMoney()
    {
        return money;
    }

    public void SetMoney(float money)
    {
        this.money = money;
    }

    public bool GetIsHappy()
    {
        return isHappy;
    }

    public void SetIsHappy(bool isHappy)
    {
        this.isHappy = isHappy;
    }

    public ClothesBag GetClothesBag()
    {
        return clothesBag;
    }
}
