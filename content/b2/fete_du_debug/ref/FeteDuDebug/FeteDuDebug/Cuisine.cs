namespace FeteDuDebug;

public class Cuisine
{
    public static char[] InverseEtiquette(char[] etiquette)
    {
        int length = etiquette.Length;
        char[] res = new char[length];
        
        for (int i = 0; i < length; i++)
        {
            res[i] = etiquette[length - i - 1];
        }

        return res;
    }

    public static string[] ModifierMenu(string[] menu, string[] nouveauxRepas)
    {
        int length = menu.Length + nouveauxRepas.Length;
        string[] res = new string[length];

        for (int i = 0; i < menu.Length; i++)
        {
            res[i] = menu[i];
        }

        for (int i = 0; i < nouveauxRepas.Length; i++)
        {
            res[menu.Length + i] = nouveauxRepas[i];
        }

        return res;
    }

    public static string[,] RepartirCanards(int longueur, int largeur, string[] canards)
    {
        string[,] table = new string[longueur, largeur];
        int canardIndex = 0;

        for (int y = 0; y < largeur; y++)
        {
            for (int x = 0; x < longueur; x++)
            {
                if (y == 0 || y == largeur - 1 || x == 0 || x == longueur - 1)
                {
                    table[x, y] =  (canardIndex < canards.Length) ? canards[canardIndex] : "";
                    canardIndex++;
                }
                else
                    table[x, y] = "";
            }
        }

        return table;
    }

    public static int CompterPlat(string[][] commandes, string plat)
    {
        int res = 0;
        
        for (int i = 0; i < commandes.Length; i++)
        {
            for (int j = 0; j < commandes[i].Length; j++)
            {
                if (commandes[i][j] == plat)
                    res++;
            }
        }
        
        return res;
    }
}