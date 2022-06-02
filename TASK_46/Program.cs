/*
Задача 46: 
Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
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
            array[i, j] = new Random().Next(-100, 100);
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

int[,] arrayRandomNumber = new int[rows, columns];
FillArray(arrayRandomNumber);
PrintArray(arrayRandomNumber);