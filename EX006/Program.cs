// Напишите программу, которая принимает на вход число N и выдает таблицу простых чисел
bool Check (int a)
{
    int sum = 0;
    for(int i = 2; i < a; i++)
    {
        if(a % i == 0) 
        {
            sum++;
        }
    }    
    if(sum >= 1) return false;
    else return true;
}


System.Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine() !);

for(int a = 2; a <= number; a++)
{
    if(Check(a) == true)
    {
        Console.Write($"{a} ");
    }
}
