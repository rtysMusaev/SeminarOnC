﻿// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = CreateArrayRndInt(5, 0, 100);
PrintArray(array);
int oddINumbers = OddINumbers(array);
Console.WriteLine($"{oddINumbers}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int OddINumbers(int[] arr)
{
    int sum = 0;
    int i = 1;
    while (i < arr.Length)
    {
        sum = sum + arr[i];
        i = i + 2;
    }
    return sum;
}