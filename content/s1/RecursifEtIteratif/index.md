---
title: "Récursif et itératif"
date: 2023-06-21T12:00:00+02:00
author: "Ilan Mayeux"
---

# Récursions et itérations

Les récursions et les itérations sont deux méthodes de résolutions de code
qui se complètent. La plupart du temps, une solution peut-être écrite des
deux façons qui ont des performances similaires, et pourtant, l'une des deux
est souvent plus intuitive et rapide à écrire.

Il faut donc maîtriser les deux pour facilement savoir s'adapter à toutes les
situations, surtout celles où une seule méthode marche réellement.

Cette suite d'exercices va vous permettre de pratiquer dans un premier temps
la récursion et dans un second temps l'itérations sur les mêmes exercices.

> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> [86868686...]
>
> *Pour vaincre la récursion, il faut avoir foi en elle.*
>
> [Stack Overflow.]

## Recursions.cs

Toutes les fonctions de cette catégorie doivent utiliser la récursion.
Aucun  `for`, de `foreach` ou quoi que ce soit d'autre n'est autorisé.

````csharp
/// <summary>
/// Ecrire une classe statique Recursion
/// </summary>
public static class Recursion {}
````

```csharp
/// <summary>
/// Ecrire une fonction FirstUpper qui prend une chaîne de caractère et renvoie le premier charactère en majuscule.
/// Si aucun charactère en majuscule n'est trouvé, il renvoie '\0'
/// </summary>
public static char FirstUpper(string str)
```
```csharp
/// <summary>
/// Ecrire une fonction fibonacchi récusive qui prend un uint n qui correspond à la valeur demandée.
/// </summary>
public static int Fib(uint n)
```

```csharp
/// <summary>
/// Ecrire une fonction Reverse qui prend une stack a et qui renvoie une autre
/// stack qui correspond à l'inverse
/// </summary>
public static Stack Reverse(Stack a)
```

```csharp
/// <summary>
/// Ecrire une fonction Palindrome qui prend un uint n et qui renvoie True si le nombre est un palindrome.
/// Exemple: Palindrome(151) // => true
/// Palindrome(1234) // => false
/// Palindrome(123454321) // => true
/// </summary>
/// <remarks>
/// n peut être un nombre de 0 à MaxUInt.
/// </remarks>
   public static bool Palindrome(uint n)
```

### LinkedList.cs (Récursion de Propriété)

````csharp
/// <summaryW
/// Ecrire une classe LinkedList avec deux attributs privés _parent de type LinkedList et _size de type int.
/// </summary>
public class LinkedList {}
````

````csharp
/// <summary>
/// Ecrire une propriété public Child de type Linked List avec un getter qui renvoie son enfant
/// et un setter qui permet de changer son enfant. Les _size des parents doivent être mis à jour.
/// <summary>
public LinkedList Child {get; set;}
````

````csharp
/// <summary>
/// Ecrire une propriété public Latest de type Linked List avec un getter qui renvoie le dernier enfant non null
/// et un setter qui permet de changer le dernier enfant si le parent existe. 
/// <summary>
public LinkedList Latest {get; set;}
````

## Iterations.cs

Toutes les fonctions de cette catégorie doivent utiliser l'itération.
Aucune `callstack` ou quoi que ce soit d'autre qui simule une récursion n'est autorisé.

````csharp
/// <summary>
/// Ecrire une classe statique Iteration
/// </summary>
public static class Iteration {}
````
```csharp
/// <summary>
/// Ecrire une fonction FirstUpper qui prend une chaîne de caractère et renvoie le premier charactère en majuscule.
/// Si aucun charactère en majuscule n'est trouvé, il renvoie '\0'
/// </summary>
public static char FirstUpper(string str);
```

```csharp
/// <summary>
/// Ecrire une fonction fibonacchi itérative qui prend un int n qui correspond à la valeur demandée.
/// </summary>
public static int Fib(int n);
```

````csharp
/// <summary>
/// Ecrire une fonction Reverse qui prend une stack a et qui renvoie une autre
/// stack qui correspond à l'inverse
/// </summary>
public static Stack Reverse(Stack a)
`````

```csharp
/// <summary>
/// Ecrire une fonction Palindrome qui prend un uint n et qui renvoie True si le nombre est un palindrome.
/// Exemple: Palindrome(151) // => true
/// Palindrome(1234) // => false
/// Palindrome(123454321) // => true
/// </summary>
/// <remarks>
/// n peut être un nombre de 0 à MaxUInt.
/// </remarks>
public static bool Palindrome(uint n);
```

### LinkedListIteratif.cs (Itérations de Propriété)

````csharp
/// <summaryW
/// Ecrire une classe LinkedListIteratif avec deux attributs privés _parent de type LinkedList et _size de type int.
/// </summary>
public class LinkedListIteratif {}
````

````csharp
/// <summary>
/// Ecrire une propriété public Child de type Linked List Iteratif avec un getter qui renvoie son enfant
/// et un setter qui permet de changer son enfant. Les _size des parents doivent être mis à jour.
/// <summary>
public LinkedListIteratif Child {get; set;}
````

````csharp
/// <summary>
/// Ecrire une propriété public Latest de type Linked List Iteratif avec un getter qui renvoie le dernier enfant non null
/// et un setter qui permet de changer le dernier enfant si le parent existe. 
/// <summary>
public LinkedListIteratif Latest {get; set;}
````


