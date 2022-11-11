// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void RangeOfCoordinate(int numberOfPlane)
{
    if( numberOfPlane == 1) Console.WriteLine("x = (0;+), y = (0;+)");
    else if( numberOfPlane == 2) Console.WriteLine("x = (-;0), y = (0;+)");
    else if( numberOfPlane == 3) Console.WriteLine("x = (-;0), y = (-;0)");
    else if (numberOfPlane == 4) Console.WriteLine("x = (0;+), y = (-;0)");
    else Console.WriteLine("Ошибка: Введенное значение находится за пределыми диапазона ");
}

System.Console.Write("Введите номер четверти: ");
int numberOfPlane;
while(!int.TryParse(Console.ReadLine(), out numberOfPlane))
{
    System.Console.WriteLine("Ошибка: Введен не верный тип данных");
    break;
}
RangeOfCoordinate(numberOfPlane);