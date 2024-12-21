namespace FeteDuDebug;

public class Canard
{
    private int _tempsTotal;
    public int TempsTotal { get => _tempsTotal; set => _tempsTotal = value * 2; }

    public Canard()
    {
        _tempsTotal = 0;
    }
}