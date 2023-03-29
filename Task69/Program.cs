﻿//Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.


double PowNumber(int numA, int NumB)
{
    if (NumB < 0) return 1 / (numA / PowNumber(numA, NumB + 1));
    
    if (NumB > 0) return numA * PowNumber(numA, NumB - 1);
    else return 1;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write(PowNumber(numberA,numberB));
