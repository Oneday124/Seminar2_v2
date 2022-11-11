// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void RangeOfCoordinate(int numberOfPlane)
{
    string range;
    if (numberOfPlane == 1) range = "x = (0;+), y = (0;+)";
    else if( numberOfPlane == 2) range = "x = (-;0), y = (0;+)";
    else if( numberOfPlane == 3) range = "x = (-;0), y = (-;0)";
    else if(numberOfPlane == 4) range = "x = (0;+), y = (-;0)";
    else range = "Не вверно введено знаение плоскости";
    System.Console.WriteLine($"Диапазон координат в четветри {numberOfPlane}: {range}");
}

System.Console.Write("Введите номер четверти: ");
int numberOfPlane = int.Parse(Console.ReadLine() ??"0");

RangeOfCoordinate(numberOfPlane);