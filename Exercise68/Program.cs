// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkCalc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkCalc(m - 1, 1);
    }
    else
    {
        return (AkkCalc(m - 1, AkkCalc(m, n - 1)));
    }
}

void AkkShow(int m, int n)
{
    Console.Write(AkkCalc(m, n)); 
}

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkShow(m,n);