// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 999)
 {
   int numberThree = ThreeDigit(number);
   Console.Write($"Последняя цифра числа -> {number}");
 }
else 
{
   Console.Write("Третьей цифры нет");
}
int ThreeDigit(int num)
{
    
   while (num > 999)
    {
        int num1 = num / 10;
    }
    int three = num % 10;
    return three;
}