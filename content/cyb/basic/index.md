---
title: "Basic"
author: "Clément"
description: "Subjects about C language"
---

# Introduction

This category shows training exercises about C language. For all questions,
please ask on the BackToBasics' [Discord server](https://discord.gg/SJGWzkU2gd).

A Makefile is already given with these rules:

- `basics`: compiles ;
- `debug`: compiles with debug flags ;
- `check`: runs the testsuite ;
- `clean`: removes all trash files.

Moreover, you must use the following header file `basics.h`:

```c
#ifndef BASICS_H
#define BASICS_H

#include <stdlib.h>

struct pair
{
    int x;
    int y;
};

void fizzbuzz(int n);
size_t my_strlen(char *s);
long binary_number(char str[]);
int hamming_distance(char *dna1, char *dna2);
int is_isogram(char *s);
struct pair move_robot(struct pair current, char *directions);

#endif /* !BASICS_H */
```

You are only allowed to uses the functions defined in the following headers:
- stdio.h

All of the code must be done inside a `basics.c` file.

Your code must compile with the following flags:
`-std=c99 -pedantic -Wall -Wextra -Werror -Wvla`.

Your code must not segfault and have any memory leak.

# FizzBuzz

## Goal

You have to implement the following function:

```c
void fizzbuzz(int n);
```

This function displays on stdout the numbers from 1 to `n` with newlines.
However, it must follow the rules:

- for multiples of 3, it should print *"Fizz"* with a newline ;
- for multiples of 5, it should print *"Buzz"* with a newline ;
- for multiples of 3 and of 5, it should print *"FizzBuzz"* with a newline.

## Example

The output of `fizzbuzz(5)` is:

```bash
1
2
Fizz
4
Buzz
```

# My strlen

You have to implement the following function:

```c
size_t my_strlen(char *s);
```

This functions returns the length of the string argument. The string can be
null.

# Binary number

You have to implement the following function:

```c
long binary_number(char str[]);
```

This function returns the integer in decimal corresponding to the binary number
given in argument.

## Example

The output of `my_strlen("110")` is `6`.
