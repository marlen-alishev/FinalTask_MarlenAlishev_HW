// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers (int M, int N)
{
    if (Math.Min(M,N)!=Math.Max(M,N))
    {
        return Math.Min(M,N) + SumNumbers(Math.Min(M,N)+1, Math.Max(M,N));
    }
    if (Math.Min(M,N)==Math.Max(M,N)) 
    {
        return Math.Min(M,N);
    }
    else return 0;
}

Console.Write("Enter M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum is " + SumNumbers(numberM,numberN));