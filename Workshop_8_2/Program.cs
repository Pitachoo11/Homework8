// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void ChangeArray(int[,] inArray)
{
    int[,] temparray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i += 1)
        for (int j = 0; j < inArray.GetLength(1); j++)

            temparray[i, j] = inArray[j, i];

    PrintArray(temparray);
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

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10); // 0,10 - это min и max диапазона заполнения случайными числами 

if (array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("Невозможно выполнить задачу");
    }
    else
    {
       PrintArray(array);
       System.Console.WriteLine();
       ChangeArray(array); 
    }
