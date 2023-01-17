public class ClothesBag
{
    private bool hasBasicShirt;
    private bool hasSuperShirt;
    private bool stardartEquiped;
    private bool basicEquiped;
    private bool superEquiped;

    public ClothesBag()
    {
        hasBasicShirt = false;
        hasSuperShirt = false;
        stardartEquiped = true;
        basicEquiped = false;
        superEquiped = false;
    }

    public bool GetHasBasicShirt()
    {
        return hasBasicShirt;
    }

    public void SetHasBasicShirt(bool hasBasicShirt)
    {
        this.hasBasicShirt = hasBasicShirt;
    }

    public bool GetHasSuperShirt()
    {
        return hasSuperShirt;
    }

    public void SetHasSuperShirt(bool hasSuperShirt)
    {
        this.hasSuperShirt = hasSuperShirt;
    }

    public bool GetStardartEquiped()
    {
        return stardartEquiped;
    }

    public void SetStardartEquiped(bool stardartEquiped)
    {
        this.stardartEquiped = stardartEquiped;
    }

    public bool GetBasicEquiped()
    {
        return basicEquiped;
    }

    public void SetBasicEquiped(bool basicEquiped)
    {
        this.basicEquiped = basicEquiped;
    }

    public bool GetSuperEquiped()
    {
        return superEquiped;
    }

    public void SetSuperEquiped(bool superEquiped)
    {
        this.superEquiped = superEquiped;
    }
}
