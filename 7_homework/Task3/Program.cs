//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.

void ReverseArray(int[] array, int i)
{
    if (i == array.Length)
    {
        return;
    }
    Console.Write($"{array[array.Length - 1 - i]} ");
    ReverseArray(array, i + 1);
}
int[] array = { 1, 2, 3, 4, 5 };
ReverseArray(array, 0);
