namespace Kontenery;

public class OverfillException : Exception
{
    public OverfillException() : base("The container is overfilled.")
    {
    }
}