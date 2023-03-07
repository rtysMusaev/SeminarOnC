// 1. Напишите программу, которая 
// 2. принимает на вход пятизначное число и проверяет, 
// 3. является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000)
{
 if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
 { 
     Console.Write("Является");
 }
 else
 {
    Console.Write("Не является");
 }
}
else
{
  Console.Write("Введено не пятизначное число");
}