// 1. Напишите программу, которая 
// 2. Принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber =SumNumber(number);
Console.WriteLine($"Сумма цифр = {sumNumber}");

int SumNumber(int num)
{
    int count = Convert.ToString(num).Length;
    int result = 0;
    int probel = 0; 
    for (int i = 0; i < count; i++)
    {
        probel = num - num % 10;
        result = result + (num - probel);
        num = num / 10;
    }
    return result;
}
