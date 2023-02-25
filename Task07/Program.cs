// 1. Напишите программу, которая принимает на вход трёхзначное число и 
// 2. на выходе показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

int LastDigit = number % 10;

Console.WriteLine($"Последняя цифра числа -> {LastDigit}");
