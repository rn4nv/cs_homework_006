Console.Clear();


double IntersectionPoint (int argK1, int argB1, int argK2, int argB2)
{
    if (argK1 == argK2)
    {
        Console.WriteLine("Прямые параллельны. (точек пересечения нет)");
    }
    else 
    {
        if (argK1 == argK2 && argB1 == argB2)
        {
            Console.WriteLine("Прямые совпадают. (бесконечное множество точек пересечения");
        }
    }
    double resultK = argK1 + (argK2 * (-1));
    double resultB = (argB1 * (-1)) + argB2;
    double resultX = resultB / resultK;
    double resultY = argK1 * resultX + argB1;

    Console.Write("Координаты точки пересечения равны: ");
    Console.Write($"({Math.Round(resultX, 2)};{Math.Round(resultY, 2)})");
    return resultX;
    return resultY;
}

Console.Write("Введите коэффициент k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите коэффициент b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
int b2 = int.Parse(Console.ReadLine());

IntersectionPoint(k1, b1, k2, b2);
