// 1. Напишите программу, которая 
// 2. Принимает на вход число и выдаёт 
// 3. количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countDigit = NumberDigits(number);
Console.WriteLine($"Количество чисел -> {countDigit}");

int NumberDigits(int num)
{
    int count = 0;
    do
    {
        num /=10;
        count++;
    }
    while (num != 0);
    return count;
}