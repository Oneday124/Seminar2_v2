// Определить номер четверти плоскости, в которой находится точка, с координатами Х и У. Решение с помощью функции

int GetNumberOfPlane (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    else return -1;
}

System.Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine() ??"0");
System.Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine() ??"0");

Console.WriteLine($"Номер четверти: {GetNumberOfPlane(x, y)}");