﻿Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    TableSquare(number);
}
else
{
    Console.WriteLine("Введено не натуральное число");
}

void TableSquare(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}    {i * i * i}");
    }
}