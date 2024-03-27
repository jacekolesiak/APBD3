namespace Kontenery;

public class CoolingKontener : Kontener
{
    public string ProductType { get; set; }
    public int ProductMaxTemp { get; set; }
    private int _kontenerTemp;

    public int KontenerTemp
    {
        get
        {
            return _kontenerTemp;
        }
        set
        {
            if (value > ProductMaxTemp)
            {
                Console.WriteLine(value);
                Console.WriteLine(ProductMaxTemp);
                throw new Exception("Kontener temperature is too high.");
            }

            _kontenerTemp = value;
        }
    }


    public CoolingKontener(int height, int depth, int ownMass, int maxLoad, string productType, int productMaxTemp, int kontenerTemp) : base(height,depth,ownMass,maxLoad)
    {
        if (kontenerTemp > productMaxTemp)
            throw new Exception("Kontener temperature is too high.");
        this.SerialNumber = $"KON-C-{this.Id}";
        this.ProductType = productType;
        this.ProductMaxTemp = productMaxTemp;
        this.KontenerTemp = kontenerTemp;
    }
    
    public override string ToString()
    {
        return base.ToString() + $", ProductType: {ProductType}, ProductMaxTemp: {ProductMaxTemp}, KontenerTemp: {KontenerTemp}";
    }
}