// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1 

Console.Write("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 999)
{
       int second = ThreeDigit(number);

   Console.WriteLine($"Вторая цифра данного числа -> {second}");
}
else 
{
   Console.WriteLine("Число не является трехзначным");
}

int ThreeDigit(int num)
{
   int firstDigit = num / 10;
   int secondDigit = firstDigit % 10;
   return secondDigit;
}