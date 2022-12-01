// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

void FormattedPrintArray(int[] NumberArray)
{
    string[] result = Array.ConvertAll(NumberArray, x => x.ToString());
    Console.WriteLine($"[ {String.Join(", ", result)} ]");
}

void FillArrayIncrement(int[] NumberArray)
{
    for (int i = 1; i < NumberArray.Length; i++)
    {
        NumberArray[i-1] = i;
    }
   FormattedPrintArray(NumberArray); 
}

int[] arr = new int[] { 1, 4, 3, 5, 4, 7, 6, 5, 4, 5, 3, 1, 8, 9, 8, 4 };
int[] freq = new int[9];

System.Console.WriteLine("Частотный словарь массива:");
FormattedPrintArray(arr);
System.Console.WriteLine();

FillArrayIncrement(freq);

for (int i = 0; i < arr.Length; i++)
{
    freq[arr[i] - 1]++;
}
 
FormattedPrintArray(freq);