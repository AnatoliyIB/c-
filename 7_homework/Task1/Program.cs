// Задача 1: Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы

void PrintNumbersBetween (int M, int N)
{
    if (M==N-1)
    {
        return;
        }
    Console.WriteLine(M+1);
    PrintNumbersBetween (M+1,N);
    

     
}

PrintNumbersBetween(1,10);
