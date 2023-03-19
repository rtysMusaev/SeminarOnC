﻿// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


int[,] CreateMatrixRndInt(int rows,  int columns, int min, int max)
{
       int[,] matrix = new int[rows, columns]; //0, 1 
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

void SquareEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] = matrix[i, j] * matrix[i, j];
        }
    }
    return;
}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();

SquareEvenIndex(array2d);
PrintMatrix(array2d);
