
    void PrintArray(int [,] array)
    {
       for (int i=0; i<array.GetLength(0); i++)
       {
         for (int j=0; j<array.GetLength(1); j++)
         { Console.Write($"{array[i,j]} ");
         
         }
         Console.WriteLine();
       }
    }

int [,] table = {{1,2,3},{3,4,5}};
PrintArray(table);



using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int [,] array)
    {
       for (int i=0; i<array.GetLength(0); i++)
       {
         for (int j=0; j<array.GetLength(1); j++)
         { Console.Write($"{array[i,j]} ");
         Console.WriteLine();
         }
          Console.WriteLine();
       }
    }

// Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int [,] array)
    {int [,] newArr=array;
        //Напишите свое решение здесь
      for (int i=0; i<array.GetLength(0); i++)
       {
         for (int j=0; j<array.GetLength(1); j++)
         {
           while (j==0) 
           {newArr[i,j]=array[i, array.GetLength(1)];
           newArr[i, array.GetLength(1)]=array[i, j];
            }
           } 
       }
      return newArr;
    }

// Обмен элементами массива
 
    public static void PrintResult(int[,] numbers)
    {
        for (int i=0; i<numbers.GetLength(0); i++)
       {
         for (int j=0; j<numbers.GetLength(1); j++)
         {Console.Write($"{numbers[i,j]} ");
         
         }
          Console.WriteLine();
       }
    }
}