/*
Задача 51: 
Задайте двумерный массив. 
Найдите сумму элементов, 
находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int SumElementsMainDiagonal(int[,] array3)
{

    int result = 0;
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array3[i, j];
            }
        }
        
    }
    return result;
}

void PrintArray(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write(array3[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] arrayRandomNumber = new int[4, 4];
int sumElement = SumElementsMainDiagonal(arrayRandomNumber);

FillArray(arrayRandomNumber);
Console.WriteLine("--------- ");
PrintArray(arrayRandomNumber);
Console.WriteLine("---------");

Console.WriteLine(sumElement);