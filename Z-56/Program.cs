// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
Print(array);
NamberArray(array);
Console.WriteLine();

void NamberArray(int[,] arr1)
{    
    int sum1= 0;
    int sum = 0;
    int m = 0;
    for (int j = 0; j < arr1.GetLength(1); j++)
    { 
        sum1 = sum1 + arr1 [0,j];
    }  
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        { 
            sum = sum + arr1 [i,j];
        } 
        if (sum1 <= sum)
        {
            m = i;
        } 
    } 
    Console.WriteLine($"{m+1} - строкa с наименьшей суммой элементов "); 
}



int[,] FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(0, 100);
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