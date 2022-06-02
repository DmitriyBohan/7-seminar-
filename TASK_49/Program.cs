/*
Задача 49: 
Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/


void FillArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(0, 10);
        }
    }
}

void SquaresEvenIndex(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array3[i, j] = array3[i, j] * array3[i, j];
            }
        }
    }
}

void PrintArray(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write(array3[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] arrayRandomNumber = new int[3, 4];

FillArray(arrayRandomNumber);
Console.WriteLine("--------- ");
PrintArray(arrayRandomNumber);
SquaresEvenIndex(arrayRandomNumber);
Console.WriteLine("---------");
PrintArray(arrayRandomNumber);
Console.WriteLine("--------- ");

