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

Tu vas devoir implémenter une classe `Smurf` qui a comme attributs :

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
