// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random() .Next(100, 1000);
Console.WriteLine($"Трехзначное число -> {number}");

int summary = PairOfDigits(number);
Console.WriteLine($"Получившиеся число из трехзначного -> {summary}");

int PairOfDigits(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int sumDigit = firstDigit * 10 + lastDigit;
    return sumDigit;
}

