// Напишите программу, которая 
// На вход принимает позиции элемента в двумерном массиве, и 
// Возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();
Console.WriteLine(rowsNumber > array2d.GetLength(0) || columnsNumber > array2d.GetLength(1)?"Такого элемента нет" : $"{rowsNumber}, {columnsNumber} -> {array2d[rowsNumber-1,columnsNumber-1]}");
// if ( rowsNumber > array2d.GetLength(0) || columnsNumber > array2d.GetLength(1))   Console.WriteLine("Такого элемента нет");
// else Console.WriteLine($"{rowsNumber}, {columnsNumber} -> {array2d[rowsNumber-1,columnsNumber-1]}");

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