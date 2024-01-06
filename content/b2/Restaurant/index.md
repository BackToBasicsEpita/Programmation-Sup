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
<!-- TODO: ARCHITECTURE -->
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

- un entier public `Money` qui correspond à son porte-monnaie, accompagné de son
  getter public et de son setter public;

Pour initialiser ces attributs et cette propriété, tu dois implémenter le
constructeur de la classe :

```csharp
/// <summary>
/// Prototype de la classe Smurf
/// </summary>
public Smurf(string name, int money, string[] entry, string[] main, string[] dessert);
```

## Récupérer des informations de nos clients

À un moment donné, nous allons vouloir savoir si des entrées, plats ou desserts
sont les préférés de nos amis les Schtroumpfs. Pour cela, nous allons utiliser
des méthodes publiques :

```csharp
/// <summary>
/// Vérifie si le plat donné en paramètre est un plat préféré de notre client
/// </summary>
public bool IsFavoriteEntry(string meal);
public bool IsFavoriteMain(string meal);
public bool IsFavoriteDessert(string meal);
```

# Quel service est-il ?

Pour chaque table, on va associé un service auquel les clients sont
actuellement. Pour cela nous allons utiliser l'énumérateur suivant dans le
fichier `Service.cs`:

```csharp
public enum Service
{
    Entry,
    Main,
    Dessert
}
```

# Les tables de notre restaurant

## Informations de la table

Dans le fichier `Table.cs`, les tables de notre restaurant vont contenir les
informations suivantes :

- un entier privé `_capacity` qui comprend le nombre de chaises autour de la
  table, intialisée à 0 au début et qui à comme maximum 4 ;
- un tableau de `Smurf` privé `_chairs` qui présente les personnes assises autour de
  la table ;
- un entier privé `_total` qui représente la note qui devra être payée à la
  fin ;
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
public void AddCost(int amount);
```

À la fin du service, nous allons vouloir connaître la note totale de la table.
Pour cela, nous allons utiliser la méthode suivante :

```csharp
/// <summary>
/// Récupère le total de la table
/// </summary>
public long GetSum();
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
