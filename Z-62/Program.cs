// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int m = 4;
int n = 4;
int num = 0;
int[,] array = new int[m, n];
FillArray(array);
Print(array);

int[,] FillArray(int[,] arr)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            num = num + 1;
            arr[0, j] = num;
        }
        for (int i = 1; i < arr.GetLength(0); i++)
        {
            num = num + 1;
            arr[i, 3] = num;
        }
        for (int k = arr.GetLength(1) - 2; k>=0; k--)
        {
            num = num + 1;
            arr[3, k] = num;
        }
        for (int z = arr.GetLength(0) - 2; z>=1; z--)
        {
            num = num + 1;
            arr[z, 0] = num;
        }
        for (int x = 1; x < arr.GetLength(1)-1; x++)
        {
            num = num + 1;
            arr[1, x] = num;
        }
        for (int y = arr.GetLength(1) - 2; y>=1; y--)
        {
            num = num + 1;
            arr[2, y] = num;
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