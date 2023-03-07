// 1. Напишите программу, которая
// 2. Принимает на вход число N и выдаёт
// 3. произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {factorial} ");

int Factorial(int num)
{
    int result = 1; 
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
     return result;
}