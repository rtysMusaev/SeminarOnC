// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(4, 0, 100);
PrintArrayDouble(array);

double maxNumberDouble = MaxNumberDouble(array);
double minNumberDouble = MinNumberDouble(array);

double sumMinMaxDouble = SumMinMaxDouble(maxNumberDouble, minNumberDouble);
Console.WriteLine($"{sumMinMaxDouble}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}  ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MaxNumberDouble(double[] arr)
{
  double max = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) 
    {
        max = arr[i];
    }
  }
  return max;
}

double MinNumberDouble(double[] arr)
{
  double min = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < min) 
    {
        min = arr[i];
    }
  }
  return min;
}


double SumMinMaxDouble(double minN, double maxN)
{
    double sum = minN - maxN;
    sum = Math.Round(sum, 1);
    return sum;
}