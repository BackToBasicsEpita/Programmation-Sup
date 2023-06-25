---
title: "IEnumerable"
date: 2023-06-25T14:21:49+02:00
author: "Greg"
---

# Introduction

Dans ce TP, nous allons manipuler l'interface `IEnumerable` afin de mieux
comprendre son fonctionnement. Pour ce faire, nous allons implémenter une classe
qui servira à lister les étudiants d'une école. 

# `StudentList.cs`

Vous devez donc implémenter une classe `StudentList` qui héritera de l'interface
`IEnumerable`. Elle devra posséder les propriétés suivantes : 

```cs
/// La liste des identifiants etudiants
int[] ids;

/// La liste des noms des etudiants
string[] names;

/// La liste des prenoms des etudiants
string[] surname;
```

Voici les fonctions que vous devrez implémenter : 

```cs
/// <summary>
/// Renvoie un IEnumerator permettant d'acceder aux informations de l'etudiant
/// sous forme de Tuple<int, string, string> (id, name, surname).
/// </summary>
public IEnumerator GetEnumerator() {}


/// <summary>
/// Renvoie un tuple (id, name, surname) correspondant a l'etudiant numero
/// <param>key</param>
/// </summary>
/// <remark>
/// Une exception InvalidArgumentException est levee si <param>key</param> est
/// trop grand
/// </remark>
public Tuple<int, string, string> this[int key] {}


/// <summary>
/// Tri la liste des identifiants selon le predicat. 
/// Pour la valeur par defaut de ce parametre, vous devrez creer une fonction
/// lambda qui tri la liste en ordre croissant.
/// </summary>
/// <remark>
/// Bien entendu, l'identifiant doit toujours correspondre au nom et prenom de
/// l'etudiant. Pour ce faire, vous pouvez implementer votre propre tri.
/// https://en.wikipedia.org/wiki/Quicksort#Algorithm 
/// </remark>
public void Sort(Predicat<int, int> predicat = {...}) {}


/// <summary>
/// Ajoute un element a la position <param>i</param>. Si <param>i</param> est
/// null, ajoute l'element a la fin de la liste.
/// </summary>
/// <remark>
/// Bien entendu, l'identifiant doit toujours correspondre au nom et prenom de
/// l'etudiant.
/// </remark>
public void Add(Tuple<int, string, string> elt, int i = null) {}


/// <summary>
/// Ajoute un element selon le critere de tri donne par le predicat.
/// Pour la valeur par defaut de ce parametre, vous devrez creer une fonction
/// lambda qui tri la liste en ordre croissant.
/// </summary>
/// <remark>
/// Bien entendu, l'identifiant doit toujours correspondre au nom et prenom de
/// l'etudiant.
/// On considere la liste deja triee
/// </remark>
public void AddSorted(Tuple<int, string, string> elt, Predicat<int, int> predicat = {...}) {}
```

# Conclusion

Voilà ! C'était assez rapide, mais simplement un rappel quant à l'utilisation de
l'interface `IEnumerable`.
