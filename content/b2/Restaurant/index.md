---
title: "Restaurant"
date: 2024-01-05T23:38:48+01:00
authors: ["Lenny", "Clément"]
---

# Introduction

Le restaurant **Chez Lenny** ouvre ses portes et accueillera à partir de ce soir
les différents Schtroumpfs pour célébrer la fin du premier semestre, la nouvelle
année 2024, et surtout, la fin des examens !

Pour cela, le chef Lenny te demande de l'aider à gérer tout ce beau monde !
On veut pouvoir proposer à un maximum de Schtroumpfs les magnifiques plats
concoctés par le meilleur chef de la ville.

Pour cela, voici l'architecture que tu dois suivre :

```
.
├── README.md
├── Smurfaurant/
│   ├── Service.cs
│   ├── Smurfaurant.cs
│   ├── Smurfaurant.csproj
│   ├── Smurf.cs
│   └── Table.cs
└── Smurfaurant.sln
```

# Quel service est-il ?

Chaque client a des plats préférés en fonction de l'entrée, du plat ou du
dessert. De plus, pour chaque table, on va associé un service auquel les clients
sont actuellement. Pour cela nous allons utiliser l'énumérateur suivant dans le
fichier `Service.cs`:

```csharp
public enum Service
{
    Entry,
    Main,
    Dessert
}
```

# Les clients

## Caractéristiques de nos clients

Comme dit précédement, les clients de notre restaurant sont nos merveilleux
Schtroumpfs. Différentes informations sont nécessaires pour les reconnaître.

Dans le fichier `Smurf.cs`, tu vas devoir implémenter une classe `Smurf` qui a
comme attributs :

- une chaîne de caractères privée `_name` pour le nom du Schtroumpf ;
- un tableau sous la forme de "jagged array" de chaîne de caractères privé
  `_favouriteMeal` qui correspond au top 2 des entrées, plats et desserts du
  client.

Une propriété va se rajouter à ces attributs :

- un nombre flottant public `Money` qui correspond à son porte-monnaie,
  accompagné de son getter public et de son setter public;

Pour initialiser ces attributs et cette propriété, tu dois implémenter le
constructeur de la classe :

```csharp
/// <summary>
/// Prototype de la classe Smurf
/// </summary>
public Smurf(string name, float money, string[] entry, string[] main, string[] dessert);
```

## Récupérer des informations de nos clients

À un moment donné, nous allons vouloir connaître les plats préférés de nos
clients en fonction du service actuel. Pour cela, nous allons utiliser la
méthode suivante :

```csharp
/// <summary>
/// Renvoie la liste des plats préférés du client en fonction du service actuel
/// </summary>
public string[] IsFavoriteMeal(Service service);
```

# Les tables de notre restaurant

## Informations de la table

Dans le fichier `Table.cs`, les tables de notre restaurant vont contenir les
informations suivantes :

- un entier privé `_capacity` qui comprend le nombre de chaises autour de la
  table, intialisée à 0 au début et qui à comme maximum 4 ;
- un tableau de `Smurf` privé `_chairs` qui présente les personnes assises
  autour de la table ;
- un nombre flottant privé `_total` qui représente la note qui devra être payée
  à la fin ;
- un énumérateur `Service` privé `_service` qui représente le service auquel
  la table est actuellement (initialement à la valeur `Entry`).

Pour accompagner les attributs, il nous faut un constructeur à la classe :

```csharp
/// <summary>
/// Prototype de la classe Table
/// </summary>
public Table(Smurf[] chairs);
```

## Manipuler les données de la table

Les serveurs du restaurant vont vouloir augmenter la note à payer à la fin du
service. Pour cela, nous allons créer la méthode suivante :

```csharp
/// <summary>
/// Augmente le total de la table de `amount` euros
/// </summary>
public void AddCost(float amount);
```

À la fin du service, nous allons vouloir connaître la note totale de la table.
Pour cela, nous allons utiliser la méthode suivante :

```csharp
/// <summary>
/// Récupère le total de la table
/// </summary>
public float GetSum();
```

Les Schtroumpfs, étant très capricieux et très superstitieux, veulent être assis
à la chaise numérotée par leur nombre préféré. Pour cela, nous allons placer
les clients à leur place favorite. Attention, le dernier client aura la priorité
sur sa chaise. La personne qui vient de perdre sa place prendra la première
place qu'elle trouve.

```csharp
/// <summary>
/// Place le client à la place souhaitée
/// </summary>
public void PlaceSmurf(Smurf smurf, int place);
```

La méthode `ClearTable()` sera appelée lorsque les clients de la table partiront
du restaurant. Pour cela, il faudra remettre en place la table et ses
caractéristiques.

```csharp
/// <summary>
/// Remet en place une table et ses caractéristiques
/// </summary>
private void ClearTable();
```

Lorsque les Schtroumpfs auront faim, ils vont pouvoir appelés eux-mêmes leur
repas avec un système ingénieux en C# ! Pour cela, pour chaque client de la
table, on va vérifier ses plats favoris avec la méthode `IsFavoriteMeal()` à
partir du service actuel. Il vous faudra rajouter dans la note de la table
le premier plat qui arrive depuis le menu sachant que le client doit pouvoir
payé son plat.

```csharp
/// <summary>
/// Choisis un plat adéquat et modifie les entrées et les sorties d'argent
/// </summary>
private void ChoseMeal(Dictionnary<string, float> menu);
```

On va vouloir faire passer au service suivant sur la table en question. Pour
cela, tu pourras appeler la méthode `ChoseMeal()`. Attention, si les clients
arrivent au dessert, tu devras retourner la note de la table et remettre la
table en place pour accueillir des nouveaux clients.

Si les clients ne sont pas encore arrivés au dessert, tu peux renvoyer 0.

```csharp
/// <summary>
/// Passe au prochain service
/// </summary>
public float NextService(Dictionnary<string, float> menu);
```

# Et enfin, le restaurant en lui même !

## Informations sur le restaurant

Passons à la dernière partie, celle la plus importante, l'implémentation
de notre restaurant lui-même ! Pour cela, dans le fichier `Smurfaurant.cs`, tu
devras créer les attributs suivants dans la classe `Resto` :

- une file de `Smurf` privée `_queue` qui correspond à la queue pour rentrer
  dans le restaurant ;
- un entier privé `_nbCustomers` donnant le nombre de clients dans le
  restaurant ;
- un nombre entier privé `_capacity` pour la capacité maximale dans le
  restaurant ;
- une liste de `Table` privée `_tables` représentant les tables de
  l'établissement.

De plus, nous avons deux propriétés importantes de notre restaurant, le menu et
les bénéfices engendrées par l'établissement :

- un dictionnaire privé `Menu` ayant pour clé le nom des plats en chaîne de caractères
  et comme valeur leur prix en nombre flottant ; accompagné par son getter et
  son setteur publics ;
- un nombre flottant privé `Benefits` correspondant à l'argent gagné durant la
  journée.

Accompagnant ces informations, il nous faut un constructeur pour la classe :

```csharp
/// <summary>
/// Prototype de la classe Resto
/// </summary>
public Resto(int nbTables, Dictionary<string, float> menu);
```

## Les différentes méthodes de notre restaurant

Un groupe d'une dizaine de Schtroumpfs arrivent au restaurant ! Il nous faut
vite les placer dans le restaurant pour éviter d'allonger la queue. Pour cela,
nous allons créer la fonction `AddGroup()` qui placera la liste de clients
donnée en paramètres dans la salle, même avec des inconnus ! Tu pourras placer
des clients dès que tu trouves de la place dans la salle.

Attention à la capacité du restaurant ! Tu peux renvoyer une `ArgumentException`
si l'ajout du groupe excède la capacité.

```csharp
/// <summary>
/// Place une liste de Schtroumpfs dans le restaurant
/// </summary>
public void AddGroup(List<Smurf> group);
```

La méthode suivante permet de faire rentrer de nouveaux clients dans le
restaurant si des tables se libèrent.

```csharp
public void NextService();
```

---

Bravo jeune combattant ! Tu as terminé le TP, n'hésite pas à nous donner des
retours par rapport à celui-ci ! Bon courage pour ton examen, que la force soit
avec toi !
