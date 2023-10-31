---
title: "Stream"
date: 2023-10-31T10:56:56+01:00
author: "Lenny"
description: "Entrainements sur la manipulation de fichiers en C#"
---


# Introduction

Ce Tp est un sujet d'entrainement pour les streams en C#.

Si vous avez la moindre question, n'hésitez pas à poser vos questions sur le serveur discord de BackToBasics ! :D

Les flux nous permettent de lire et écrire dans un fichier et c'est exactement le but de ce tp, réviser la manipulation de fichiers.

# Stream.cs

N'oubliez pas de faire 

```csharp
using System.IO;
```

## Existe_file
```csharp
/// <summary>
/// Ecrire une fonction qui prend une string path et qui renvoie si le fichier existe.
/// </summary>
public static bool Existe_file(string path)

```

## MyReplace

```csharp

/// <summary>
/// Ecrire une fonction qui prend une string path, un char a remplacer, et par quoi le remplacer.
/// Elle devra modifier le fichier et le creer si celui-ci n'existe pas.
/// </summary>
/// <remarks>
    //Le fichier modifié devra se finir par un retour a la ligne
    // Si une erreur apparait, renvoyer une ArgumentException avec comme message "erreur".
/// </remarks>
public static void MyReplace(string path, char toReplace, char replace)

```
Prenons le fichier : *test*
```
Bonjour,
Ceci est un message de test.
J'espere que vous allez reussir vos exams :D.
```

```csharp
MyReplace(path, 'e', 'f'); // path est le chemin de mon fichier
```
On aura alors le fichier *test* suivant:
```
Bonjour,
Cfci fst un message de tfst.
J'fspfrf quf vous allfz rfussir vos fxams :D.

```

## DeleteLines

```csharp

/// <summary>
/// Ecrire une fonction qui prend une string path et un entier n, la fonction modifie le fichier entré en parametres et devra supprimer toutes les lignes les multiples de n
/// Elle devra modifier le fichier et le creer si celui-ci n'existe pas.
/// </summary>
/// <remarks>
    //Le fichier modifié devra se finir par un retour a la ligne
    // Si le fichier n'existe pas alors renvoyer une ArgumentException avec comme message "erreur"
/// </remarks>
public static void DeleteLines(string path, int n)

```
Prenons le fichier : *ToDelete*
```
0
1
2
3
4
5
6
7
8
9
10
11
12
```

```csharp
    public static void DeleteLines(string path, int 2); // path est le chemin de mon fichier
```
On aura alors le fichier *test* suivant:

```
1
3
5
7
9
11

```

