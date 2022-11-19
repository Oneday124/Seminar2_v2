// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

void Kub (int number)
{
    for(int i = 1; i <= number; i++)
    {
        int kub = i * i * i;
        System.Console.WriteLine($"Куб числа {i} = {kub}");
    }
}

System.Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine() !);

Kub(number);


