﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) Console.WriteLine($"Нет, не выходной день");
 else if (number == 2) Console.WriteLine($"Нет, не выходной день");
  else if (number == 3) Console.WriteLine($"Нет, не выходной день");
   else if (number == 4) Console.WriteLine($"Нет, не выходной день");
    else if (number == 5) Console.WriteLine($"Нет, не выходной день");
     else if (number == 6) Console.WriteLine($"Да, выходной день");
      else if (number == 7) Console.WriteLine($"Да, выходной день");
      
    else Console.WriteLine("Такого дня недели не существует");