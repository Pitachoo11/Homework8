// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void MinRowValue (int[,] inputArray)
{
    int sum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            temp += inputArray[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка: "+index+"");
    Console.WriteLine();
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

if (rows == columns)
{
   System.Console.WriteLine("Некорректный ввод. Кол-во строк и столбцов должно различаться"); 
}
else
{
    int[,] array = GetArray(rows, columns, 0, 10); // 0,10 - это min и max диапазона заполнения случайными числами 
    PrintArray(array);
    System.Console.WriteLine();
    MinRowValue(array);
}

