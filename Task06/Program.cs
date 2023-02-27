// 1. Напишите программу, которая на вход принимает число 
// 2. Является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2)
{
    Console.Write("Четное");
}
else 
{
    Console.Write("Нечетное");
}