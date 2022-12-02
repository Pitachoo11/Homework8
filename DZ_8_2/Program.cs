// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void MultiplyArrays (int[,] inputArray1, int[,] inputArray2)
{
    for (int i = 0; i < inputArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray1.GetLength(1); j++)
        {
            inputArray1[i,j] *= inputArray2[i,j];
        }
    }
    System.Console.WriteLine();
    PrintArray(inputArray1);
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите размерность массивов для перемножения X = [X,X]: ");
int sizeArray = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(sizeArray, sizeArray, 1, 5);
int[,] array2 = GetArray(sizeArray, sizeArray, 1, 5);

PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);

MultiplyArrays(array1,array2);