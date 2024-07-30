//  Задайте значения M и N. Напишите программу, 
//  которая выведет все натуральные числа в промежутке от M до N. 
//  Использовать рекурсию, не использовать циклы.

void Main()
{
    int number1 = ReadInt("Введите число M: ");
    int number2 = ReadInt("Введите число N: ");
    PrintNumber(number1, number2);
}


void PrintNumber(int m, int n)
{
    if (m != n)
    {
        if (m > n)
        {
            PrintNumber(m - 1, n);
            System.Console.Write(" " + m + " ");
        }
        else
        {
                
            PrintNumber(m, n - 1);
            System.Console.Write(" " + n + " ");

        }
    }
    else
    {
        System.Console.Write(m);
    }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();