---
title: Fête du débogage
authors: ["Julie"]
---

*Tous les ans pour la nouvelle année, les canards organisent la fête du débogage :
un grand évenement durant lequel ils mangent tous ensembles en racontant
les histoires des plus grands bogues de l'année.*

*Mais la fête n'a pas fini d'être préparée. Et bien qu'ils déboguent toute
la journée, les canards peuvent aussi avoir besoin d'un peu d'aide.*

## Un bon repas (Cuisine.cs)

*Dans les cuisines, rien n'est prêt, et les cuisiniers sont en panique. C'est
le moment de leur apporter un peu d'aide.*

> Toutes les méthodes de cette partie seront écrites dans le fichier `Cuisine.cs`.

### Bocaux mal étiquetés

*Les étiquettes des bocaux de la cuisine ont été imprimés à l'envers. Aide les
canards à les remettres dans l'ordre*

Écris une méthode `InverseEtiquette` qui prend un array en paramètre et renvoie
un nouvel array avec tous les éléments inversés.

```cs
public static char[] InverseEtiquette(char[] etiquette) { }
```

```cs
char[] etiquette = { 'é', 'l', 'b', ' ', 'e', 'd', ' ', 's', 'n', 'i', 'a', 'r', 'g' };
char[] etiquetteInverse = Cuisine.InverseEtiquette(etiquette);
Console.WriteLine(new string(etiquetteInverse)); // == "grains de blé"
```

### Changement de menu

*Les canards ne sont pas satisfaits du menu, et veulent y ajouter quelques plats.*

Écris une méthode `ModifierMeu` qui ajoute les éléments d'une liste
`nouveauxRepas` à la fin de la liste `menu`, et renvoie le menu final.

> L'ordre des repas dans la liste finale doit rester le même.

```cs
public static string[] ModifierMenu(string[] menu, string[] nouveauxRepas)
```

```cs
string[] menu = {
    "Blé doré à la poele",
    "Pain perdu",
    "Salade de mais"
};

string[] nouveauMenu = Cuisine.ModifierMenu(menu, new []{ "Tarte au raisin", "Soupe d'orge pelé" });
foreach (string plat in nouveauMenu)
    Console.WriteLine(plat);
```

```text
Blé doré à la poele
Pain perdu
Salade de mais
Tarte au raisin
Soupe d'orge pelé
```

### Plan de table

*Une fois les préparatifs en cuisine terminés, il est temps de préparer la salle
des fêtes*.

Écris une fonction `RépartirCanards` qui renvoie un plan de table avec le nom
des canards à placer.

Un plan de table est représenté à l'aide d'une matrice de dimension `longueur`
x `largeur` :

```cs
string[,] table = { // longueur = 3, largeur = 2
    {"canard 1", "canard 2", "canard 3"},
    {"canard 4", "canard 5", "canard 6"}
};
```

Chaque string correspond au nom d'un canard placé, une string vide
indiquant qu'aucun canard n'est sur la place. Les canards sont uniquement placés
sur le contour de la table.

Les canards à placer sont dans la liste `canards`. Chaque canard est placé
de gauche à droite, puis de haut en bas (en suivant l'ordre de l'exemple de
table ci-dessus).

S'il n'y a pas assez de canard, les places restent vides. S'il y a trop de
canards, les canards en trop sont ignorés.

```cs
public static string[,] RepartirCanards(int longueur, int largeur, string[] canards)
```

```cs
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
```

```text
 Canard 1 Canard 3 Canard 5
 Canard 2 Canard 4         

 Canard 1 Canard 4 Canard 6
 Canard 2          Canard 7
 Canard 3 Canard 5 Canard 9
```

### Toujours plus de commandes

*C'est l'heure de compter les commandes ! Les chefs on besoin d'aide pour
connaitre rapidement le nombre de plat total qu'ils doivent préparer*.

Écris une fonction `CompterPlat` qui renvoie le nombre d'occurences du plat dans
la commande.

```cs
public static int CompterPlat(string[][] commandes, string plat) { }
```

```cs
string[][] commandes =
{
    new [] { "Pain perdu", "Salade de mais"},
    new [] { "Salade de mais"},
    new [] { "Tarte au raisin", "Blé doré à la poele", "Pain perdu"},
    new [] { "Soupe d'orge pelé", "Salade de mais", "Pain perdu", "Salade de mais"},
};

Console.WriteLine(Cuisine.CompterPlat(commandes, "Salade de mais")); // == 4
```

## Gestion des stocks (Entrepot.cs)

*Pour que les cuisines fonctionnent correctement, il faut une bonne gestion des
stocks de nourriture. Mais là aussi, l'organisation laisse à désirer...*

> Toutes les méthodes de cette partie seront écrites dans le fichier `Entrepot.cs`.

Listes  
Dico  
Queue

## Qui sera le meilleur débogueur ?

*L'activité la plus attendue de la soirée est la compétition de débogage.
Chaque participant est mis devant un bogue, et doit trouver sa source dans
le temps imparti.*  
*Le gagnant est celui ayant résolu le plus de bogues le plus vite*

### Plein de participants (Canard.cs)

Crée une classe `Canard` avec les caractéristiques suivantes :

- un attribut privé `int _tempsTotal`, initialisé à `0` par le constructeur;
- une propriété publique `int TempsTotal` avec un getter et un setter :
    - le getter renvoie la valeur de `_tempsTotal`,
    - le setter mets `_tempsTotal` à 2 fois la valeur donnée.

```cs
public Canard() { }
```

```cs
Canard canard = new Canard();
Console.WriteLine(canard.TempsTotal); // == 0
canard.TempsTotal = 4;
Console.WriteLine(canard.TempsTotal); // == 8
```

### Toujours plus de bogues (Bogues/Bogue.cs)

*Pour une bonne compétition de débogage, il faut avant tout des bogues à trouver.
Aide les canards organisateur à les écrire*.

Crée une classe `Bogue` avec les caractéristiques suivantes :

- un attribut privé `string _messageErreur`, le message d'erreur que génère le bogue;
- un attribut privé `string _raison`, la raison du bogue;
- une propriété publique `string MessageError` avec un getter **uniquement** qui
    renvoie la valeur de `_messageErreur`.

Le constructeur initialise `_messageErreur` et `_raison` avec les valeurs
passées en paramètre.

```cs
public Bogue(string messageErreur, string raison)
```

```cs
Bogue bogue = new Bogue("Message d'erreur", "C'est une très bonne raison");
// bogue.MessageError == "Message d'erreur", bogue._raison == "C'est une très bonne raison"
```

### Tentative de débogage (Bogues/Bogue.cs)

*Une fois le bug identifié, les canards tentent de deviner sa cause*.

Écris une méthode `DevinerRaison` qui renvoie si la raison donnée en paramètre
est bien la raison du bogue.

> Les majuscules n'ont pas d'importance dans la comparaison

```cs
public bool DevinerRaison(string raison)
```

```cs
Bogue vilainBogue = new Bogue("Il y a une erreur... quelque part", "Et pourquoi pas ?");
vilainBogue.DevinerRaison("Parce que y'a pas de code"); // == False
vilainBogue.DevinerRaison("eT POuRqUOi PAs ?"); // == True
```

### Il manque quelque chose là, non ? (Bogues/BogueVarNonDef.cs)

*L'un des canards semble avoir trouvé l'origine du premier bug, il s'agirait
d'une variable qui n'existe pas*.

Crée une classe `BogueVarNonDef` qui hérite de `Bogue`.

Le constructeur prend en paramètre 2 éléments : le numéro de ligne où l'erreur
a eu lieu `noLigne`, et le nom de la variable fautive `var`.

Le message d'erreur du bogue est "`Erreur à la ligne {noLigne}: {var} n'est pas défini`".
Sa raison est "`{var} n'existe pas`".

> Le mot clé `base` doit être utilisé dans cette fonction.

```cs
public BogueVarNonDef(int noLigne, string var) { }
```

```cs
BogueVarNonDef varNonDef = new BogueVarNonDef(10, "toto");
Console.WriteLine(varNonDef.MessageErreur); // == "Erreur à la ligne 10: toto n'est pas défini"
Console.WriteLine(varNonDef.DevinerRaison("toto n'existe pas")); // == True
```

### Problème de calculatrice (Bogues/BogueCalcul.cs)

*Il semblerait que le canard qui a conçu les programmes de la compétition avait
une calculatrice défaillante.*

Crée une classe `BogueCalcul` qui hérite de `Bogue`.

Le message d'erreur du bogue est "`La fonction ne renvoie pas le résultat attendu`".
Sa raison est "`Mauvais calcul`".

> Le mot clé `base` doit être utilisé dans cette fonction.

```cs
public BogueCalcul() { }
```

```cs
BogueCalcul erreurCalcul = new BogueCalcul();
Console.WriteLine(erreurCalcul.MessageErreur); // == "La fonction ne renvoie pas le résultat attendu"
Console.WriteLine(erreurCalcul.DevinerRaison("Mauvais calcul")); // == True
```

### Calcul qui prend du temps (Bogues/BogueCalcul.cs)

*Malheureusement pour les canards, trouver la source d'une erreur de calcul, ça
prend du temps*.

Écris une méthode `MauvaisResultat` qui prend le canard participant en paramètre
et ajoute `1` à son `TempsTotal`.

> N'oublie pas que le setter de `TempsTotal` fait une multiplication par 2.
C'est donc normal si le temps final soit 2 fois plus grand.

```cs
public void MauvaisResultat(Canard participant) { }
```

```cs
Canard participant = new Canard();
Console.WriteLine(participant.TempsTotal); // == 0

BogueCalcul bogueCalcul = new BogueCalcul();
bogueCalcul.MauvaisResultat(participant);
Console.WriteLine(participant.TempsTotal); // == 2
```

### Un bogue en cache toujours un autre (Programme.cs)

*Les canards se rendent vite compte que les bogues sont empilés les uns sur les
autres, et qu'il faut les résoudre un par un pour venir à bout du programme*.

Crée une classe `Bogue` avec les caractéristiques suivantes :

- un attribut privé `Stack<Bogue> _bogues`, la suite de bogues du programme;
- une propriété publique `int NombreBogues` avec un getter **uniquement** qui
    renvoie le nombre d'éléments dans `_bogues`.

Le constructeur prend en paramètre un array de `Bogue`. Les bogues sont ajoutés
en haut de la stack suivant leur ordre d'apparition dans l'array.

```cs
Programme prog = new Programme(new Bogue[] { new BogueCalcul(), new BogueVarNonDef(42, "canard") });
Console.WriteLine(prog.NombreBogues); // == 2
// prog._bogues == (Haut de la stack) { BogueVarNonDef, BogueCalcul } (Bas de la stack)
```

### Résolution finale (Programme.cs)

*Il est maintenant temps pour nos participants de résoudre le programme final.
Qui sera à la hauteur du défi ?*

Écris une méthode `Résoudre` qui prend en paramètre un canard participant et
la liste de raison de chaque bogue.  
La première raison de la liste correspond au premier bogue de la stack,
la deuxième au second bogue, etc.

Tant que la stack n'est pas vide, on récupère le bogue en haut de la stack et
on essaye de deviner sa raison.

Si la raison a été devinée correctement : on passe au bogue suivant, et on
retire le bogue de la stack.

Sinon, si le bogue était un `BogueCalcul`, on appelle la méthode
`MauvaisResultat`.

La méthode renvoie le nombre de bogues ayant été résolu.

```cs
public int Resoudre(Canard participant, string[] raisons) { }
```

```cs
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
```

```text
Début de l'épreuve finale
Temps écoulé : 0
Nombre de bogues dans le programme : 4

Première résolution
Bogues résolus durant l'essai : 1
Temps écoulé : 2
Nombre de bogues dans le programme : 3

Résolution finale
Bogues résolus durant l'essai : 1
Temps écoulé : 2
Nombre de bogues dans le programme : 2
```
