// 1. Напишите программу, которая 
// 2. по заданному номеру четверти, 
// 3. показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine($"Введите номер четверти");
string numQuarter = Console.ReadLine();

Console.WriteLine(Range(numQuarter));

string Range(string num)
{
    if (num == "1") return "x > 0, y > 0";
    if (num == "2") return "x < 0, y > 0";
    if (num == "3") return "x < 0, y < 0";
    if (num == "4") return "x > 0, y < 0";
    return "Введите корректный номер";
}