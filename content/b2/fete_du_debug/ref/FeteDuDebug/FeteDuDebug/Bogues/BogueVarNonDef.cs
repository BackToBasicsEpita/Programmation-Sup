namespace FeteDuDebug.Bogues;

public class BogueVarNonDef : Bogue
{
    public BogueVarNonDef(int noLigne, string var) : base($"Erreur à la ligne {noLigne}: {var} n'est pas défini", $"{var} n'existe pas")
    {}
}