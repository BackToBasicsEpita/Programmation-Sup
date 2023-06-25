---
title: "Matrix"
weight: 5
author: "Kolowy"
description: "Entrainements sur les matrices en C#"
---

Ce TP est un sujet d'entrainement pour les Matrices.

Si vous avez le mondre probleme n'hésitez pas à aller sur le serveur de l'asso et poser vos questions ou à envoyer un MP à `kolowy_` sur discord

```
/// <summary>
/// Cette fonction doit afficher la matrice. Voir l'exemple ci-dessous pour plus d'informations
/// </summary>

static void matrixPrint(int[,] matrix)
{
    // TODO
    throw new NotImplementedException();
}

/// <summary>
/// Transpose une matrice carrée en échangeant les lignes et les colonnes.
/// </summary>
/// <param name="matrix">La matrice carrée à transposer.</param>
/// <returns>La matrice transposée.</returns>
static int[,] matrixTranspose(int[,] matrix)
{
    // TODO
    throw new NotImplementedException();
}

/// <summary>
/// Point d'entrée du programme.
/// </summary>
static void Main()
{
    int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    int[,] matriceTransposee = matrixTranspose(matrix);

    Console.WriteLine("Matrice d'origine :");
    matrixPrint(matrix);

    Console.WriteLine("\nMatrice transposée :");
    matrixPrint(matriceTransposee);
}

Main();
```
