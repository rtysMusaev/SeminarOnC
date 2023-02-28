// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

bool multiplicity = Multiplicity(number);

Console.WriteLine(multiplicity ? "Кратно" : "Не кратно");

bool Multiplicity(int num)
{
   if (num % 7 == 0 && num % 23 == 0) return true;
   else return false;
}