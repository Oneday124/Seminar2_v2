// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

double DistanseBetweenPoints (int xa, int ya, int xb, int yb)
{
    int ab, bc;
    if(xa > xb) ab = xa - xb;
    else ab = xb - xa;
    if(ya > yb) bc = ya - yb;
    else bc = ya - yb;
    double distans = Math.Sqrt((ab*ab)+(bc*bc));
    return distans;
}

Console.WriteLine("Введите координату X для точки А: ");
int.TryParse(Console.ReadLine(), out int xa);
Console.WriteLine("Введите координату Y для точки А: ");
int.TryParse(Console.ReadLine(), out int ya);
Console.WriteLine("Введите координату X для точки B: ");
int.TryParse(Console.ReadLine(), out int xb);
Console.WriteLine("Введите координату Y для точки B: ");
int.TryParse(Console.ReadLine(), out int yb);

Console.WriteLine($"Расстояние между точками А и В = {DistanseBetweenPoints (xa, ya, xb, yb)}");