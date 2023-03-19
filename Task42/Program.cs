// 1. Напишите программу, которая 
// 2. Будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number);
Console.WriteLine(decToBin);

string DecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}