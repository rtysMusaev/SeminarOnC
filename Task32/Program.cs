﻿// 1. Напишите программу замена элементов массива: 
// 2. Положительные элементы замените на соответствующие отрицательные, 
// 3. И наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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

void NegativeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = - arr[i];
    }
}

int[] array = CreateArrayRndInt(5, -5, 5);
PrintArray(array);

NegativeArray(array);

PrintArray(array);

