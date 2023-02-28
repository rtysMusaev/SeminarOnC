// 1. Напишите программу, которая на вход принимает число (N)
// 2. На выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное целове число");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
  int count = 2;
  while (count <= number)
  {
    Console.Write(count + " ");
    count = count + 2;
  }

}
else 
{
   Console.WriteLine("Введите натуральное число"); 
}
