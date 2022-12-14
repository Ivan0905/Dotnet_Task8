// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int[,] array = GetArray(4, 4, 0, 5);
// PrintArr(array);
// Console.WriteLine();
// PrintArrSort(array);
int[,] GetArray(int n, int m, int min, int max)
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArr(int[,] arr)
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

void PrintArrSort(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// int[,] array = GetArray(4, 3, 0, 5);
// PrintArr(array);
// Console.WriteLine();
// Console.WriteLine($"Минимальная сумма чисел в {PrintArrSumm(array)} строке");

int PrintArrSumm(int[,] arr)
{
    int summ = 0;
    int temp = int.MaxValue;
    int k = 0;
    int[] array = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ = summ + arr[i, j];
        }
        Console.WriteLine($"Сумма {i} строки равна {summ}");
        if (temp > summ)
        {
            temp = summ;
            k = i;
        }
    }
    return k;
}

// Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int[,] array = GetArray(2, 2, 0, 5);
// int[,] array2 = GetArray(2, 2, 0, 5);
// PrintArr(array);
// Console.WriteLine();
// PrintArr(array2);
// Console.WriteLine();
// PrintArr(Matrix(array,array2));


int[,] Matrix(int[,] arr1, int[,] arr2)
{
    int[,] myarray = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                myarray[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return myarray;
}