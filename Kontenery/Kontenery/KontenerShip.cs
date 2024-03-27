namespace Kontenery;

public class KontenerShip
{
    public KontenerShip(int maxSpeed, int maxNumberOfKonteners, int maxMassOfAllKonteners)
    {
        MaxSpeed = maxSpeed;
        MaxNumberOfKonteners = maxNumberOfKonteners;
        MaxMassOfAllKonteners = maxMassOfAllKonteners;
    }

    public int MaxSpeed { get; set; }
    public int MaxNumberOfKonteners { get; set; }
    public int MaxMassOfAllKonteners { get; set; }
    public List<Kontener>? Konteners { get; set; } = new List<Kontener>();

    public void RemoveKontener(String serialNumber)
    {
        for (int i = 0; i < Konteners.Count; i++)
        {
            if (Konteners[i].SerialNumber.Equals(serialNumber))
                Konteners.RemoveAt(i);
        }
    }

    public void AddConteiners(List<Kontener> list)
    {
        foreach (var kontener in list)
        {
            Konteners.Add(kontener);
        }
    }

    public void ReplaceKontener(Kontener newKontener, string serialNumber)
    {
        for (int i = 0; i < Konteners.Count; i++)
        {
            if (Konteners[i].SerialNumber.Equals(serialNumber))
                Konteners[i] = newKontener;
        }
    }

    public void MoveKontener(KontenerShip kontenerShip, string serialNumber)
    {
        for (int i = 0; i < this.Konteners.Count; i++)
        {
            if (this.Konteners[i].SerialNumber.Equals(serialNumber))
            {
                kontenerShip.Konteners.Add(this.Konteners[i]);
                this.Konteners.RemoveAt(i);
            }
        }
    }
    
    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"Max Speed: {MaxSpeed}");
        sb.AppendLine($"Max Number Of Konteners: {MaxNumberOfKonteners}");
        sb.AppendLine($"Max Mass Of All Konteners: {MaxMassOfAllKonteners}");

        if (Konteners != null && Konteners.Count > 0)
        {
            sb.AppendLine("Konteners:");
            foreach (var kontener in Konteners)
            {
                sb.AppendLine($" - {kontener}");
            }
        }
        else
        {
            sb.AppendLine("No Konteners loaded.");
        }

        return sb.ToString();
    }
}