// 1. Напишите программу, которая 
// 2. Принимает на вход три числа и проверяет, 
// 3. Может ли существовать треугольник со сторонами такой длины.



Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool triangle = Triangle(number1, number2, number3);
Console.WriteLine(triangle? "Да":"Нет");  // triangle == true(false)

bool Triangle(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}