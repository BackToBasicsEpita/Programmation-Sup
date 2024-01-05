---
title: "Smurf Studies"
date: 2024-01-04T02:33:57+01:00
authors: ["FIXME"]
---

# Introduction

Oh mais c'est bientôt l'heure des examens!
Malheureusement, les Schtroumpfs on passé leurs vacances à réveillonner.

Pendant les vacances ils ont totalement oublié toutes les notions qu'ils ont vu lors du premier semestre...

Heureusement le grand Schtroumpf a pensé à eux et a préparé un TP pour les aider à réviser. :D

# Tree

```bash
.
├── README.md
├── SmurfStudies/
│   ├── City.cs
│   ├── Course.cs
│   ├── Date.cs
│   ├── Person.cs
│   ├── Prof.cs
│   ├── Program.cs
│   ├── Room.cs
│   ├── SmurfStudies.csproj
│   ├── Student.cs
│   └── Subject.cs
└── SoutienPartiel.sln
```

# Setup

## City.cs

Pour commencer, nous vous donnons les différentes villes d'où peuvent venir les élèves.
*Notez que nous stockerons ces villes dans un type énumérateur nommé :* `City`

```csharp
public enum City
{
    PARIS,
    LYON,
    TOULOUSE,
    RENNES,
    STRASBOURG,
};
```

## Subject.cs
Nous vous donnons également les différentes matières sur lesquelles les élèves seront intérrogés.
*Notez que nous stockerons ces matières dans un type énumérateur nommé :* `Subject`

```csharp
public enum Subject
{
    MATH,
    ALGO,
    PROG,
    ELEC,
    PHYS,
    ARCHI,
    METHODO,
    ANGLAIS,
};
```

## Date.cs

Ensuite, chaque élève doit avoir sa date de naissance. Pour cela, nous allons implémenter une classe `Date`

```csharp
/// <summary>
/// Prototype de la classe Date 
/// </summary>
public Date(int day, int month, int year);
```

*A noter que* : notre classe `Date` contient les propriétés suivantes :
- `Day`, un entier public avec un getter et un setter publics. 
- `Month`, un entier public avec un getter et un setter publics.
- `Year`, un entier public avec un getter et un setter publics.

*Attention*, un élève ne peut pas avoir une date invalide. Si une date est invalide, lancer : `ArgumentException`.

**Tip** : Vérifie que la date est correcte ;)


## Person.cs

Maintenant, que nous pouvons savoir d'où viennent les élèves et quelle est leur date de naissance, créons notre classe `Person`
```csharp
/// <summary>
/// Prototype de la classe Person 
/// </summary>
public Person(string firstname, string lastname, Date birthDate, City campus);
```

*A noter que* : notre classe `Person` contient les attributs suivants :
- `private string _firstname;`
- `private string _lastname;`

Et les propriétés suivantes :
- `Login`, une chaîne de caractères publique avec un getter public et un setter privé
- `BirthDate`, une `Date` publique avec un getter public et un setter privé
- `Campus`, une `City` publique avec un getter public et un setter public

*De plus*, le `Login` est une `string` qui est composé de : `prenom.nom`.

# L'HERITAGE

## Student.cs

Très bien nous avons une classe `Person` mais il faut différencier les professeurs des élèves. Pour cela, nous allons d'abord nous occuper de créer la classe `Student` qui hérite de la classe `Person`.

```csharp
/// <summary>
/// Prototype de la classe Student 
/// </summary>
public Student(string firstname, string lastname, Date birthDate, City campus, int uid, int promo);
```

*A noter que* : la classe `Student` possède deux proprités publics : 
- `Uid`, un entier public avec un getter public et un setter public
- `Promo`, un entier public avec un getter public et un setter public

## Prof.cs

Les élèves n'ont pas appris tout seul et les matières ne sont pas corrigées par nimporte qui dans le village !
Il nous faut donc une classe `Prof` qui hérite également de la classe `Person`.


```csharp
/// <summary>
/// Prototype de la classe Prof 
/// </summary>
public Prof(string firstname, string lastname, Date birthDate, City campus, List<Subject> subjects);
```

*A noter que* : comme pour la classe `Student`, `Prof` a une propriété :
- `PreferredSubjects`, une liste de `Subject` avec un getter public et un setter public

# LES COURS

## Room.cs

Il ne peut pas y avoir de cours sans salle (sauf pendant la pandémie mais c'était vachement triste).
Chaque salle de classe a un plan de classe. Pour cela, nous avons besoin de la classe : `Room`.

```csharp
/// <summary>
/// Prototype de la classe Room 
/// </summary>
public Room(List<Student> students);
```

*A noter que* : la classe `Room` contient une propriété :
- `Student[,] ClassPlan`, une matrice de `Student` avec un getter public et un setter public 

Chaque classe est construite de la même façon : 7 rangées de 6 tables.

On va se dire que les étudiants vont se mettre à leur place définie en fonction de leur ordre dans la liste donnée en argument. (On les place colonnes par colonnes en commençant par la dernières rangée).

*Attention* : Il n'y aura pas toujours assez d'élève pour remplir la salle de classe.

**TIP** : On peut se dire que plus le nombre (de la colonne ou de la rangée) est élevé, plus il est loin de la porte/au fond.

## Course.cs

Maintenant qu'il y a une salle pour accueillir le cours, il faut savoir où chaque cours se déroulera.
Pour cela, rien de plus simple, il nous faut créer une classe `Course`

```csharp
/// <summary>
/// Prototype de la classe Course 
/// </summary>
public Course(Prof prof, Subject subject, Room room, int startTime, int duration);
```

*A noter que* : la classe `Course` contient des propriétés :
- `Prof`, un `Prof` avec un getter public et un setter public
- `Students`, une liste `Student` avec un getter public et un setter public
- `Room`, une `Room` avec un getter public et un setter public
- `Subject`, un `Subject` avec un getter public et un setter privé
- `StartTime`, un entier avec un getter public et un setter privé
- `Duration`, un entier avec un getter public et un setter privé

# Fin

Grâce à ce petit TP récapitulatif sur les classes, le grand Schtroumpf a bien aidé les Schtroumpfs du village à réviser pour leurs examens. :D