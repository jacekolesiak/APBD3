namespace Kontenery;

public abstract class Kontener(int height, int depth, int ownMass, int maxLoad)
{
    private static int _nextId = 0;
    
    public int Id { get; } = _nextId++;
    public int CargoLoad { get; set; }
    public int Height { get; set; } = height;
    public int Depth { get; set; } = depth;
    public int OwnMass { get; set; } = ownMass;
    public int MaxLoad { get; set; } = maxLoad;
    public string SerialNumber { get; set; }

    public void ClearLoad()
    {
        this.CargoLoad = 0;
    }

    public void LoadCargo(int cargoLoad)
    {
        if (cargoLoad + this.CargoLoad > MaxLoad)
            throw new OverfillException();
        this.CargoLoad = cargoLoad;
        
    }

    public override string ToString()
    {
        return $"Id: {Id}, SerialNumber: {SerialNumber}, Height: {Height}, Depth: {Depth}, OwnMass: {OwnMass}, MaxLoad: {MaxLoad}, CargoLoad: {CargoLoad}";
    }
}