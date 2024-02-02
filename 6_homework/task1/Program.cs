// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.



char [,] CreateMatrix(int rowCount, int columsCount) // Функция создания матрицы
{char[,] matrix = new char[rowCount, columsCount];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = (char)rnd.Next(97, 123);
}
}
return matrix;
}

void ShowMatrix(char[,] matrix) // Функция вывода матрицы на экран
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
}

char[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);



