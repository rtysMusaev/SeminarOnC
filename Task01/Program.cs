// 1. Напишите программу, которая на вход принимает два числа 
// 2. Проверяет является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Является ли первое число квадратом второго");

Console.WriteLine("Введите первое число");

int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberSecond = Convert.ToInt32(Console.ReadLine());

int square = numberSecond * numberSecond;

if (numberFirst == square)
{
   Console.WriteLine("Да"); 
}
 else 
 {
    Console.WriteLine("Нет"); 
 }