﻿//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] array = CreateMatrixRndInt(3, 3, 0, 20);
PrintMatrix(array);

Console.WriteLine();

Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

int[,] CreateMatrixRndInt(int rows,  int columns, int min, int max)
{
       int[,] matrix = new int[rows, columns];
       Random rnd = new Random();
       
       for (int i = 0; i < matrix.GetLength(0); i++)
       {
           for (int j = 0; j < matrix.GetLength(1); j++)
           {
               matrix[i, j] = rnd.Next(min, max + 1);
           }
       }
       return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i< matrix.GetLength(0); i++)
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        Console.Write($"{matrix[i, j], 3} ");
     }
     Console.WriteLine();
    }
}

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void WriteArray(int[,] matrix)
{
    for (int i = 0; i< matrix.GetLength(0); i++)
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        Console.Write($"{matrix[i, j], 3} ");
     }
     Console.WriteLine();
    }
}