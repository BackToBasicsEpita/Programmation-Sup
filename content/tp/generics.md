---
title: "Generics partiel S2"
date: 2020-09-15T11:30:03+00:00
# weight: 1
# aliases: ["/first"]
author: "Ilan Mayeux"
showToc: true
TocOpen: false
draft: false
hidemeta: false
comments: false
description: "Entrainements Generics pour le partiel des S2 à EPITA"
canonicalURL: "https://canonical.url/to/page"
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
    image: "<image path/url>" # image path/url
    alt: "<alt text>" # alt text
    caption: "<text>" # display caption under cover
    relative: false # when using page bundles set this to true
    hidden: true # only hide on current single page
editPost:
    URL: "https://github.com/<path_to_repo>/content"
    Text: "Suggest Changes" # edit text
    appendFilePath: true # to append file path to Edit link
---

Voici un entrainement sur les Generics pour le partiel de programation S2

Si vous avez le moindre problème n'hésitez pas à aller sur le serveur de l'asso et poser vos questions ou à envoyer un MP à `Taliayaka | イラヌ | 生嵐#3699` sur discord

```
/*
 * Écrire une classe Element utilisant un Generic <T> ayant deux attributs public:
 * - T Content
 * - Element<T>? Next
 * Son constructeur prend content de type T et initialize Next à null.
 */

public Element(T content);

/*
 * Écrire une classe List utilisant un Generic <T> ayant un attribut privé:
 * - Element<T>? _head
 * Son constructeur crée un nouvel _head avec l'élément donné en paramètre.
 */

public List();
public List(T element);

/*
 * Écrire une fonction Add qui ajoute le T element donné à la fin de la liste chaîné de _head.
 * Si head n'existe pas, element devient la nouvelle head de la liste;
 */

public void Add(T element);

/*
 * Écrire un indexeur qui permet d'accéder ou set le content de l'élement d'index donné.
 * Une IndexOutOfRangeException est throw si l'index est invalide
 *
 * Hint: Une fonction auxiliaire renvoyant l'élément d'index donné peut être utile.
 */

public T this[int index];

/*
 * Écrire une fonction Pop qui supprime et renvoie l'élement à l'index donné.
 * Si l'index est invalide, une InvalidIndexException est renvoyée.
 */

 public T Pop(int index = 0);
```
