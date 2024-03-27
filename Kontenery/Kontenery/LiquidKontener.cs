namespace Kontenery;

public class LiquidKontener : Kontener, IHazardNotifier
{
    public string CargoType { get; set; }

    public LiquidKontener(int height, int depth, int ownMass, int maxLoad, string cargoType) : base(height,depth,ownMass,maxLoad)
    {
        this.SerialNumber = $"KON-L-{this.Id}";
        this.CargoType = cargoType;
    }

    public void SendNotification()
    {
        Console.WriteLine($"A dangerous even has occured, container {SerialNumber}");
    }
    
    public void LoadCargo(int cargoLoad)
    {
        if (CargoType.Equals("hazardous"))
        {
            if (cargoLoad + this.CargoLoad > MaxLoad * 0.5)
            {
                SendNotification();
                return;
            }
        }
        if (CargoType.Equals("regular"))
        {
            if (cargoLoad + this.CargoLoad > MaxLoad * 0.9)
            {
                SendNotification();
                return;
            }
        }

        if (cargoLoad + this.CargoLoad > MaxLoad)
            throw new OverfillException();

        this.CargoLoad = cargoLoad;
        
    }
    
    public override string ToString()
    {
        return base.ToString() + $", CargoType: {CargoType}";
    }
}