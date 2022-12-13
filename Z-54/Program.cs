// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
Print(array);
NamberArray(array);
Console.WriteLine();
Print(array);

int[,] NamberArray(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
        {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int n = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = n;
                    }
                }
        }
    }
    return arr1;
}



int[,] FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-99, 100);
                }
            }
        return arr;
    }

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
        Console.WriteLine();
        }
}