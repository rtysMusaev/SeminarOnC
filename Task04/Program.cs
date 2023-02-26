// 1. Напишите программу, которая принимает на вход три числа
// 2. Выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



Console.WriteLine("Найти максимальное из трех данных чисел");

Console.Write("Введите первое число: ");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;

if (numberB > max) max = numberB;

if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное число -> {max}");

