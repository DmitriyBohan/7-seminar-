/*
Задача 48: 
Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

Console.WriteLine("Задайте размер двумерного массива");
Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------------------");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i+j;
        }
    }
}

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);