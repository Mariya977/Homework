// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите значение k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// int x = (b2 - b1)/(k1 - k2);
// int y = (k1 * ((b2-b1)/(k1-k2) + b1));
// Console.WriteLine($"Точка пересечения [{x}:{y}]");

// Написала решение с семинара, потому что не понимала, как сделать. 
// Я не поняла, почему в строке 20 (double[] result = new double[2]) мы ставим индекс [2]..

Console.Write("Введите через пробел b1, k1, b2, k2: ");
string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);

Console.WriteLine(String.Join(" ", GetPoint(b1,k1,b2,k2)));

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB2 - inB1) / (inK1 - inK2);
    result[1] = inK1 * result[0] + inB1;
    return result;
}

