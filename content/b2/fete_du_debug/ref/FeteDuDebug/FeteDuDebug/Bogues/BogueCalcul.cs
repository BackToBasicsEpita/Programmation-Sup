namespace FeteDuDebug.Bogues;

public class BogueCalcul : Bogue
{
    public BogueCalcul() : base("La fonction ne renvoie pas le résultat attendu", "Mauvais calcul")
    {}

    public void MauvaisResultat(Canard participant)
    {
        participant.TempsTotal++;
    }
}