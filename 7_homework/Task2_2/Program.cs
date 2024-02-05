//Задача 2.2: Задайте значения M и N. Напишите программу,
//которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии

void PrintNumbersBetween(int M, int N)
{
    if (M == N - 1)
    {
        return;
    }
    if (M % 2 == 1)
    {
        Console.WriteLine(M + 1);
    }
    else
    {
        Console.WriteLine(M + 2);
    }

    PrintNumbersBetween(M + 2, N);
}

PrintNumbersBetween(1, 10);
