---
title: "Basics partiel S2"
date: 2020-09-15T11:30:03+00:00
# weight: 1
# aliases: ["/first"]
author: "B2B"
# author: ["Me", "You"] # multiple authors
showToc: true
TocOpen: false
draft: false
hidemeta: false
comments: false
description: "Entrainements basic pour le partiel des S2 à EPITA"
disableHLJS: true # to disable highlightjs
disableShare: true
disableHLJS: false
hideSummary: false
searchHidden: true
ShowReadingTime: true
ShowBreadCrumbs: true
ShowPostNavLinks: true
ShowWordCount: true
ShowRssButtonInSectionTermList: true
UseHugoToc: true
cover:
    image: "BTB_logo.png" # image path/url
    caption: "Entrainement Partiel EPITA S2" # display caption under cover
    relative: false # when using page bundles set this to true
    hidden: true # only hide on current single page
---

Voici un entrainement aux basic de partiel de programation S2

Si vous avez le mondre probleme n'hésitez pas à aller sur le serveur de l'asso et poser vos questions ou à envoyer un MP à `kolowy#6639` sur discord

```
/*
 * Ecrire une fonction **FiBuzz(int n)** qui affiche tous les entiers de 1 à n, un par ligne.
 * Si l'entier est multiple de 3, afficher "Fizz" au lieu de l'entier.
 * Si l'entier est multiple de 5, afficher "Buzz" au lieu de l'entier.
 * Si l'entier est à la fois multiple de 3 et de 5, afficher "FizzBuzz" au lieu de l'entier.
 */
static void FiBuzz(int n)
{
    // TODO
    throw new NotImplementendException()
}

/*
 * Ecrire une fonction récursive Factorielle(int n),
 * qui prend en entrée un entier positif n et retourne sa factorielle.
 */
static int Factorielle(int n)
{
    // TODO
    throw new NotImplementendException()
}

/*
 * Ecrire une fonction Fibonacci : F(n) = F(n-1) + F(n-2)
 * La suite de Fibonacci est une suite d'entiers dans laquelle chaque terme est la somme des deux termes qui le précèdent.
 * Elle commence par les termes 0 et 1.
 */
static int Fibonacci(int n)
{
    // TODO
    throw new NotImplementendException()
}

/*
 * Ecrire une fonction EstPalindrome(string s) qui prend en entrée une chaîne de caractères
 * et qui retourne vrai si la chaîne est un palindrome
 * (c'est-à-dire si elle peut être lue de la même façon de gauche à droite et de droite à gauche), et faux sinon.
 * Attention a prendre en compte les majuscule et les espaces
 * Exemple : "kayak" est un palindrome, "Eric notre valet alla te laver ton cire» en est un aussi
 */
static bool EstPalindrome(string s)
{
    // TODO
    throw new NotImplementendException()
}

/*
 * Ecrire une fonction FilterList(List<int> liste, Func<int, bool> predicate),
 * qui prend en entrée une liste d'entiers et une fonction prédicat,
 * et qui retourne une nouvelle liste ne contenant que les éléments de la liste d'origine
 * pour lesquels la fonction prédicat retourne vrai.
 * La fonction doit utiliser une lambda expression pour le prédicat.
 */
static List<int> FilterList(List<int> list, Func<int, bool> predicate)
{
    // TODO
    throw new NotImplementendException()
}

/*
 * Ecrire une fonction InverserPile(Stack<int> pile), qui prend en entrée une pile d'entiers
 * et qui retourne une nouvelle pile contenant les éléments de la pile d'origine dans l'ordre inverse.
 * La fonction doit utiliser une file pour inverser la pile.
 */
static Stack<int> InverserPile(Stack<int> pile)
{
    // TODO
    throw new NotImplementendException()
}

/*
 * Ecrire une fonction SelectionnerPairs(List<int> liste), qui prend en entrée une liste d'entiers
 * et qui retourne une nouvelle liste contenant tous les nombres pairs de la liste d'origine,
 * triés par ordre croissant. La fonction doit utiliser la syntaxe de requête Linq.
 */
List<int> SelectionnerPairs(List<int> liste)
{
    // TODO
    throw new NotImplementendException()
}
```
