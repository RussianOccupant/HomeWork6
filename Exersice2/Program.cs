/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetAnswer(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        Console.WriteLine($"Прямые пересекутся в точке ({x}; {y})");
    }
    return b1;
}

void Main()
{
    Console.Clear();
    Console.Write("Enter b1: ");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter k1: ");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter b2: ");
    double b2 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter k2: ");
    double k2 = double.Parse(Console.ReadLine()!);
    double answer = GetAnswer(b1, k1, b2, k2);
}
Main();