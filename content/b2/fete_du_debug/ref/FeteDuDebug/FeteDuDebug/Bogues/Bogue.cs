namespace FeteDuDebug.Bogues;

public class Bogue
{
    private string _messageErreur;
    public string MessageErreur => _messageErreur;

    private string _raison;
    
    public Bogue(string messageErreur, string raison)
    {
        _messageErreur = messageErreur;
        _raison = raison;
    }

    public bool DevinerRaison(string raison)
    {
        return _raison.ToLower() == raison.ToLower();
    }
}