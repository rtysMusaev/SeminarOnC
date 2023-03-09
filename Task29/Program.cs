﻿// 1. Напишите программу, которая 
// 2. Задаёт массив из 8 элементов и 
// 3. Выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int [8];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
}

void PrintArray(int [] arr)
{
   for ( int i = 0; i < arr.Length - 1; i++)
   {
    Console.Write($"{arr[i]}, ");
   }

   Console.Write($"{arr[arr.Length -1]} - > [");

   for (int i = 0; i < arr.Length -1; i++)
   {
    Console.Write($"{arr[i]}, ");
   }
   Console.Write($"{arr[arr.Length -1]}]");
}