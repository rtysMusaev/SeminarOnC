// 1. Напишите программу, которая
// 2. Принимает на вход число (А) и выдаёт 
// 3. Сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до -> {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
       sum += i;  //sum = sum + i;
    }
    return sum;
}