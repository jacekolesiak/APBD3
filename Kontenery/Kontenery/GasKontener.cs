namespace Kontenery;

public class GasKontener : Kontener, IHazardNotifier
{
    public int Pressure { get; set; }
    
    public GasKontener(int height, int depth, int ownMass, int maxLoad, int pressure) : base(height, depth, ownMass, maxLoad)
    {
        this.Pressure = pressure;
        this.SerialNumber = $"KON-G-{this.Id}";
    }
    
    public void SendNotification()
    {
        Console.WriteLine($"A dangerous even has occured, container {SerialNumber}");
    }

    public void ClearLoad()
    {
        if (this.CargoLoad >= this.MaxLoad * 0.05)
            this.CargoLoad = (int)(this.MaxLoad * 0.05);
    }
    
    public override string ToString()
    {
        return base.ToString() + $", Pressure: {Pressure}";
    }
}