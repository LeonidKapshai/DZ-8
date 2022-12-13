// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите значение  1 матрицы слево на право");
int[,] array = new int[2, 2];
int[,] array2 = new int[2, 2];
FillArray(array);
Console.WriteLine();
Console.WriteLine("Введите значение  2 матрицы слево на право");
int[,] array1 = new int[2, 2];
FillArray(array1);
Console.WriteLine();
Print(array);
Console.WriteLine();
Print(array1);
MathArray (array,array1);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
Print(array2);

int[,] MathArray(int[,] arr1, int[,] arr2)
{
    array2[0,0] = (arr1[0,0] * arr2[0,0]) + (arr1[0,1] * arr2[1,0]);
    array2[0,1] = (arr1[0,0] * arr2[0,1]) + (arr1[0,1] * arr2[1,1]);
    array2[1,0] = (arr1[1,0] * arr2[0,0]) + (arr1[1,1] * arr2[1,0]);
    array2[1,1] = (arr1[1,0] * arr2[0,1]) + (arr1[1,1] * arr2[1,1]);
    return array2;
}



int[,] FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Значение:");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
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