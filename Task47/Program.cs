﻿// 1. Задайте двумерный массив размером m×n, 
// 2. Заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5       7      -2     -0,2

//   1    -3,3       8     -9,9

//   8     7,8    -7,1        9

double[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

double[,] CreateMatrixRndInt(int rows,  int columns, int min, int max)
{
       double[,] matrix = new double[rows, columns]; //0, 1 
       Random rnd = new Random();
       
       for (int i = 0; i < matrix.GetLength(0); i++)
       {
           for (int j = 0; j < matrix.GetLength(1); j++)
           {
               matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
           }
       }
       return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i< matrix.GetLength(0); i++)
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        Console.Write($" {matrix[i  ,j], 3} ");
     }
     Console.WriteLine();
    }
}