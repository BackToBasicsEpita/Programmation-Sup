// See https://aka.ms/new-console-template for more information

using FeteDuDebug;
using FeteDuDebug.Bogues;

/// Exo 1
char[] etiquette = { 'é', 'l', 'b', ' ', 'e', 'd', ' ', 's', 'n', 'i', 'a', 'r', 'g' };
char[] etiquetteInverse = Cuisine.InverseEtiquette(etiquette);
Console.WriteLine(new string(etiquetteInverse));

/// Exo 2
string[] menu = {
    "Blé doré à la poele",
    "Pain perdu",
    "Salade de mais"
};

string[] nouveauMenu = Cuisine.ModifierMenu(menu, new []{ "Tarte au raisin", "Soupe d'orge pelé" });
foreach (string plat in nouveauMenu)
    Console.WriteLine(plat);

/// Exo 3

string[,] table1 = Cuisine.RepartirCanards(2, 3, new[] {"Canard 1", "Canard 2", "Canard 3", "Canard 4", "Canard 5"});

for (int i = 0; i < table1.GetLength(0); i++)
{
    for (int j = 0; j < table1.GetLength(1); j++)
        Console.Write(table1[i, j].PadLeft(9));
    Console.WriteLine();
}

Console.WriteLine();
string[,] table2 = Cuisine.RepartirCanards(3, 3, new[] {
    "Canard 1", "Canard 2", "Canard 3",
    "Canard 4", "Canard 5", "Canard 6",
    "Canard 7", "Canard 9", "Canard 10"
});

for (int i = 0; i < table2.GetLength(0); i++)
{
    for (int j = 0; j < table2.GetLength(1); j++)
        Console.Write(table2[i, j].PadLeft(9));
    Console.WriteLine();
}

/// Exo 4

string[][] commandes =
{
    new [] { "Pain perdu", "Salade de mais"},
    new [] { "Salade de mais"},
    new [] { "Tarte au raisin", "Blé doré à la poele", "Pain perdu"},
    new [] { "Soupe d'orge pelé", "Salade de mais", "Pain perdu", "Salade de mais"},
};

Console.WriteLine(Cuisine.CompterPlat(commandes, "Salade de mais"));

/// Exo 5
/// Exo 6
/// Exo 7
    
/// Exo 8
Canard canard = new Canard();
Console.WriteLine(canard.TempsTotal);
canard.TempsTotal = 4;
Console.WriteLine(canard.TempsTotal);

/// Exo 9
Bogue bogue = new Bogue("Message d'erreur", "C'est une très bonne raison");
// bogue.MessageError == "Message d'erreur", bogue._raison == "C'est une très bonne raison"

/// Exo 10
Bogue vilainBogue = new Bogue("Il y a une erreur... quelque part", "Et pourquoi pas ?");
vilainBogue.DevinerRaison("Parce que y'a pas de code"); // == False
vilainBogue.DevinerRaison("eT POuRqUOi PAs ?"); // == True

/// Exo 11
BogueVarNonDef varNonDef = new BogueVarNonDef(10, "toto");
Console.WriteLine(varNonDef.MessageErreur); // == "Erreur à la ligne 10: toto n'est pas défini"
Console.WriteLine(varNonDef.DevinerRaison("toto n'existe pas")); // == True

/// Exo 12
BogueCalcul erreurCalcul = new BogueCalcul();
Console.WriteLine(erreurCalcul.MessageErreur); // == "La fonction ne renvoie pas le résultat attendu"
Console.WriteLine(erreurCalcul.DevinerRaison("Mauvais calcul")); // == True

/// Exo 13
Canard participant = new Canard();
Console.WriteLine(participant.TempsTotal); // == 0

BogueCalcul bogueCalcul = new BogueCalcul();
bogueCalcul.MauvaisResultat(participant);
Console.WriteLine(participant.TempsTotal); // == 2

/// Exo 14
Programme prog = new Programme(new Bogue[] { new BogueCalcul(), new BogueVarNonDef(42, "canard") });
Console.WriteLine(prog.NombreBogues); // == 2
// prog._bogues = (Haut de la stack) { BogueCalcul, BogueVarNonDef } (Bas de la stack)

// Exo 15
Canard dernierParticipant = new Canard();
Programme progFinal = new Programme(new Bogue[] {
    new BogueCalcul(),
    new BogueVarNonDef(15, "bogue"),
    new BogueCalcul(),
    new BogueCalcul()
});

Console.WriteLine("Début de l'épreuve finale");
Console.WriteLine($"Temps écoulé : {dernierParticipant.TempsTotal}");
Console.WriteLine($"Nombre de bogues dans le programme : {progFinal.NombreBogues}");

int boguesResolus = progFinal.Resoudre(dernierParticipant, new [] {
    "Mauvais calcul",
    "Mauvaise raison",
    "Erreur à la ligne 15: bogue n'est pas défini",
    "Mauvais calcul",
});

Console.WriteLine("\nPremière résolution");
Console.WriteLine($"Bogues résolus durant l'essai : {boguesResolus}");
Console.WriteLine($"Temps écoulé : {dernierParticipant.TempsTotal}");
Console.WriteLine($"Nombre de bogues dans le programme : {progFinal.NombreBogues}");

boguesResolus = progFinal.Resoudre(dernierParticipant, new [] {
    "Mauvais calcul",
    "Erreur à la ligne 15: bogue n'est pas défini",
    "Mauvais calcul",
});

Console.WriteLine("\nRésolution finale");
Console.WriteLine($"Bogues résolus durant l'essai : {boguesResolus}");
Console.WriteLine($"Temps écoulé : {dernierParticipant.TempsTotal}");
Console.WriteLine($"Nombre de bogues dans le programme : {progFinal.NombreBogues}");