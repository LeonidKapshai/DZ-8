// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
int x = 2;
int y = 2;
int z = 2;

int[,,] array = new int[x,y,z];
FillArray(array);
Print(array);

int[,,] FillArray(int[,,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = new Random().Next(-99, 100);  
                    }
                }
            }
        return arr;
    }

void Print(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {   
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write($"{arr[i, j, k]} ({i},{j},{k}) ");  
                }
            }
        Console.WriteLine();
        }
}