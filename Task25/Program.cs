// 1. Напишите цикл, который
// 2. Принимает на вход два числа (A и B) и 
// 3. Возводит число A в натуральную степень B

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sumDegree = SumDegree(numberA, numberB);
Console.WriteLine($"{sumDegree}");

int SumDegree(int numA, int numB)
{
    int sum = 1;
    for ( int i = 1; i <= numB; i++)
    {
      sum = sum * numA;
    }
    
    return sum;
}