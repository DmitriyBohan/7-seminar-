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

int[,] GetRandomArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");   //   \t -добовляет табуляцию
    const int starIndex =65;
    for (var i = starIndex; i <starIndex+ arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{((char)i)}]\t"); // берем индификатор по кодировке i и преобразуем его в char  (символ)
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write("[" + i + "]" + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int rowNumber = Convert.ToInt32(Console.ReadLine());
int colomnNumber = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = GetRandomArray(rowNumber,colomnNumber);
Print2DArray(randomArray);