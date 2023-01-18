public class LemonadeStand
{
    private float lemonadeValue;
    private int totalBlenders;
    private int bowls;
    private int basicBlenders;
    private int superBlenders;
    private float lemonadeSpeed;

    private bool premiumLemons;
    private bool open;

    public LemonadeStand(float lemonadeValue)
    {
        this.lemonadeValue = lemonadeValue;
        this.totalBlenders = 0;
        this.bowls = 0;
        this.basicBlenders = 0;
        this.superBlenders = 0;
        this.lemonadeSpeed = 5;
        this.open = true;
        this.premiumLemons = false;
    }

    public float GetLemonadeValue()
    {
        return lemonadeValue;
    }

    public void SetLemonadeValue(float lastSale)
    {
        this.lemonadeValue = lastSale;
    }

    public int GetTotalBlenders()
    {
        return totalBlenders;
    }

    public void SetTotalBlenders(int totalBlenders)
    {
        this.totalBlenders = totalBlenders;
    }

    public int GetBowls()
    {
        return bowls;
    }

    public void SetBowls(int bowls)
    {
        this.bowls = bowls;
    }

    public int GetBasicBlenders()
    {
        return basicBlenders;
    }

    public void SetBasicBlenders(int basicBlenders)
    {
        this.basicBlenders = basicBlenders;
    }

    public int GetSuperBlenders()
    {
        return superBlenders;
    }

    public void SetSuperBlenders(int superBlenders)
    {
        this.superBlenders = superBlenders;
    }

    public float GetLemonadeSpeed()
    {
        return lemonadeSpeed;
    }

    public void SetLemonadeSpeed(float lemonadeSpeed)
    {
        this.lemonadeSpeed = lemonadeSpeed;
    }

    public bool GetOpen()
    {
        return open;
    }

    public void SetOpen(bool open)
    {
        this.open = open;
    }

    public bool GetPremiumLemons()
    {
        return premiumLemons;
    }

    public void SetPremiumLemons(bool premiumLemons)
    {
        this.premiumLemons = premiumLemons;
    }
}
