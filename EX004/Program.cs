// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом

void GetArray(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        while (number > 99999)
        {
            number = number / 10;
        }
        array[i] = number % 10;
        number = number / 10;
    }
}

bool CheckForPolindrom(int[] array)
{
    int i = 0;
    int lenght = array.Length - 1;
    int sum = 0;
    while (i < lenght)
    {
        if(array[i] == array[lenght])
        {
            i++;
            lenght = lenght - 1;
            sum = sum + 1;
        }
        else
        {
            break;
        }
    }
    if(sum > 0) return true;
    else return false;
}


System.Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ??"0");
if(number < 99999 && number > 0)
{
    int [] array = new int [5];

    GetArray(array, number);
    if(CheckForPolindrom(array) == true) Console.WriteLine($"Введенное число: {number} является полиндромом");
    else Console.WriteLine($"Введенное число: {number} не является полиндромом");
}
else    Console.WriteLine("Введенное число не является пятизначным");