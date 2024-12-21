namespace FeteDuDebug;

using FeteDuDebug.Bogues;

public class Programme
{
    Stack<Bogue> _bogues = new Stack<Bogue>();
    
    public int NombreBogues => _bogues.Count;

    public Programme(Bogue[] bogues)
    {
        foreach (Bogue bogue in bogues)
        {
            _bogues.Push(bogue);
        }
    }

    public int Resoudre(Canard participant, string[] raisons)
    {
        int nbResolu = 0;
        while (_bogues.Count > 0)
        {
            Bogue bogue = _bogues.Peek();
            if (!bogue.DevinerRaison(raisons[nbResolu]))
            {
                if (bogue is BogueCalcul)
                    ((BogueCalcul)bogue).MauvaisResultat(participant);
                break;
            }

            _bogues.Pop();
            nbResolu++;
        }
        
        return nbResolu;
    }
}