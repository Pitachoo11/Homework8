//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void CreateArray3D(int[,,] inputArray)
{
  int[] temp = new int[inputArray.GetLength(0) * inputArray.GetLength(1) * inputArray.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < inputArray.GetLength(0); x++)
  {
    for (int y = 0; y < inputArray.GetLength(1); y++)
    {
      for (int z = 0; z < inputArray.GetLength(2); z++)
      {
        inputArray[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int k = 0; k < inArray.GetLength(2
            ); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите измерение X трехмерного массива: ");
int xdimension = int.Parse(Console.ReadLine()!);

Console.Write("Введите измерение Y трехмерного массива: ");
int ydimension = int.Parse(Console.ReadLine()!);

Console.Write("Введите измерение Z трехмерного массива: ");
int zdimension = int.Parse(Console.ReadLine()!);

int[,,] array3D = new int[xdimension, ydimension, zdimension];

CreateArray3D(array3D); 

PrintArray(array3D);
System.Console.WriteLine();