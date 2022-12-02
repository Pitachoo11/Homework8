// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArrayBySpiral (int[,] inputArray)
{
    int columnIndexMin = 0;
    int rowIndexMin = 0;
    int columnIndexMax = inputArray.GetLength(0) - 1;
    int rowIndexMax = inputArray.GetLength(0) - 1;
    int currentRow = 0;
    int currentColumn = 0;
    int move = 1; // 1 - вправо, 2 - вниз, 3 - влево, 4 - вверх
        for (int i = 1; i <= Math.Pow(inputArray.GetLength(0),2); i++)
        {
            inputArray[currentRow, currentColumn] = i;
                switch (move)
                {
                    case 1:
                        if (currentColumn < columnIndexMax)
                        {
                            currentColumn++;
                        }
                        else
                        {
                            move = 2;
                            rowIndexMin++;
                            currentRow++;
                        }
                        break;
                    
                    case 2:
                        if (currentRow < rowIndexMax)
                        {
                            currentRow++;
                        }
                        else
                        {
                            move = 3;
                            columnIndexMax--;
                            currentColumn--;
                        }
                        break;
                    
                    case 3:
                        if (currentColumn > columnIndexMin)
                        {
                            currentColumn--;
                        }
                        else
                        {
                            move = 4;
                            columnIndexMin++;
                            currentRow--;
                        }
                        break;
                    
                    case 4:
                        if (currentRow > rowIndexMin)
                        {
                            currentRow--;
                        }
                        else
                        {
                            move = 1;
                            rowIndexMax--;
                            currentColumn++;
                        }
                        break;
                    
                    default:
                        break;
                }
            }
            PrintArray(inputArray);
            System.Console.WriteLine();
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

Console.Write("Введите размерность массива X = [X,X]: ");
int sizeArray = int.Parse(Console.ReadLine()!);

int[,] array = new int[sizeArray, sizeArray]; 

PrintArray(array);
System.Console.WriteLine();
FillArrayBySpiral(array);