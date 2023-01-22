// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double FindX(double k1, double k2, double b1, double b2)
{
    double x = 0;
    x = (b2-b1)/(k1-k2);
    return x;
}

double FindY(double x, double k1, double b1)
{
    double y = 0;
    y = k1*x+b1;
    return y;
}

Console.WriteLine("Давайте найдем точку пересечения двух прямых заданных двумя уравнениями:");
Console.WriteLine("y = k1*x + b1");
Console.WriteLine("y = k2*x + b2");
Console.WriteLine();

Console.WriteLine("Введите значение k1:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double a0 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
double b0 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Итак, теперь наши уравнения выглядат так:");
Console.WriteLine($"y = {a}*x + {b}");
Console.WriteLine($"y = {a0}*x + {b0}");

Console.WriteLine("А теперь вычислим точку пересечения двух прямых...");

Console.WriteLine($"Кооридинаты точек пересечения: ({FindX(a, a0, b, b0):f2} ; {FindY(FindX(a, a0, b, b0), a, b):f2})");