public class LemonadeStand
{
    private float lemonadeValue;
    private int totalBlenders;
    private int bowls;
    private int basicBlenders;
    private int superBlenders;

    private bool open;

    public LemonadeStand(float lemonadeValue)
    {
        this.lemonadeValue = lemonadeValue;
        totalBlenders = 1;
        bowls = 1;
        basicBlenders = 0;
        superBlenders = 0;
        open = true;
    }

    public float GetLemonadeValue()
    {
        return lemonadeValue;
    }

    public void SetLemonadeValue(float lastSale)
    {
        this.lemonadeValue = lastSale;
    }

    public float GetTotalBlenders()
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

    public bool GetOpen()
    {
        return open;
    }

    public void SetOpen(bool open)
    {
        this.open = open;
    }
}
