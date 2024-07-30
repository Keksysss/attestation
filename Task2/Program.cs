// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


void Main()
{
    int numberM = ReadInt("Введите число M: ");
    int numberN = ReadInt("Введите число N: ");
    Akk(numberM, numberN);
    Console.WriteLine($"Значение функции Аккермана - А({numberM}, {numberN}) равно: {Akk(numberM, numberN)}");
}

int Akk(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akk(m - 1, 1);
    else
        return Akk(m - 1, Akk(m, n - 1));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();