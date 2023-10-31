---
title: "Itératif et Récusif"
date: 2023-10-31T10:56:56+01:00
author: "Lenny"
description: "Entrainements sur la récursivité et itérativité"
---

# Introduction

Ce Tp est un sujet d'entrainement pour les méthodes récursives et itératives.

Si vous avez la moindre question, n'hésitez pas à poser vos questions sur le serveur discord de BackToBasics ! :D

# Iterations.cs

Le but, ici, va être de résoudre ces problèmes seulement en utilisant des boucles `while` et `for`.



## Reverse_int
```csharp

/// <summary>
/// Ecrire une fonction qui prend un int (n) et renvoie ses chiffres dans le sens inverse.
/// </summary>
/// <remark>
/// n peut être négatif.
/// </remark>
public static int Reverse_int(int n)

```

```csharp
// Résultats attendus : 

Revers_int(4); // == 4
Revers_int(-4); // == -4
Revers_int(24); // == 42
Revers_int(-123456); // == -654321

```

## FindSub

```csharp

/// <summary>
/// Ecrire une fonction qui prend une string s et une string sub,et renvoie si sub est contenue dans la string s.
/// </summary>
/// <remark>
/// Si une des deux chaine est vide alors la méthode lève une exception de type `ArgumentException`.
/// </remark>
public static bool FindSub(string s, string sub)

```

```csharp
// Résultats attendus : 

Revers_int("Clement est le plus beau", "moche"); // == false
Revers_int("Clement est le plus beau", "beau"); // == true
Revers_int("Je est un autre.", ""); // == ArgumentException()

```

## FirstUpper

```csharp

/// <summary>
/// Ecrire une fonction qui prend une string s renvoie la string avec toutes les premieres lettres (lettre entre a-z) de chaque mot en majuscule
/// (un mot est précédé d'un espace).
/// </summary>
/// <remark>
/// Attention au premier mot de chaque string.
/// </remark>
public static bool FindSub(string s, string sub)

```

```csharp
// Résultats attendus : 

Revers_int("Je me crois en enfer, donc j'y suis."); // == "Je Me Crois En Enfer, Donc J'y Suis."
Revers_int(""); // == ""
Revers_int("!abc !def ghi .klm"); // == "!abc !def Ghi .klm"

```

## Replace_char

```csharp

/// <summary>
/// Ecrire une fonction qui prend une string source, le char toReplace a remplacer par le char replace en parametre et retourne la nouvelle string
/// </summary>
public static string Replace_char(string source,char toReplace, char replace)

```

```csharp
// Résultats attendus : 

Revers_int("De la programmation avant toute chose.", "a", "*"); // == "De l* progr*mm*tion *v*nt toute chose."

```

# Recursion.cs

Le but, ici, va être de résoudre ces problèmes seulement en utilisant de la récursion (pas de boucle).

## is_alpahnum
```csharp

/// <summary>
/// Ecrire une fonction qui prend un int i et une string s en parametre et renvoie true si la fonctione n'a que des char alphanumériques a partir de l'index i.
/// </summary>
/// <remark>
/// i >=0
/// </remark>
public static bool is_alpahnum(string s, int i)

```

```csharp
// Résultats attendus : 

is_alpahnum("abcdef132", 0); // == true
is_alpahnum("!abcdef", 0); // == false
is_alpahnum("!abcdef", 1); // == true
is_alpahnum("abcdef!", 15); // == true


```

## is_alpahnum
```csharp

/// <summary>
/// Ecrire une fonction qui prend un int i et une string s en parametre et renvoie true si la fonctione n'a que des char alphanumériques a partir de l'index i.
/// </summary>
/// <remark>
/// i >=0
/// </remark>
public static bool is_alpahnum(string s, int i)

```

```csharp
// Résultats attendus : 

is_alpahnum("abcdef132", 0); // == true
is_alpahnum("!abcdef", 0); // == false
is_alpahnum("!abcdef", 1); // == true
is_alpahnum("abcdef!", 15); // == true


```
## Reverse_str

```csharp

/// <summary>
/// Ecrire une fonction qui prend une string source de longueur length en parametre et retourn la string inversée.
/// </summary>
/// <remark>
/// condition: length = s.Length
/// </remark>
public static string Reverse_str(string source, int length)

```

```csharp
// Résultats attendus : 

Reverse_str("42",2); // == "24"
Reverse_str("123",3); // == "321"
Reverse_str("ABcdeF",6); // == "FedcBA"

```
