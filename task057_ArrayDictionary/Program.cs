// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

// Набор данных                             Частотный массив
// 
// { 1, 9, 9, 0, 2, 8, 0, 9 }              0 встречается 2 раза
//                                         1 встречается 1 раз
//                                         2 встречается 1 раз
//                                         8 встречается 1 раз
//                                         9 встречается 3 раза
// 
// 1, 2, 3                                 1 встречается 3 раза
// 4, 6, 1                                 2 встречается 2 раз
// 2, 1, 6                                 3 встречается 1 раз
//                                         4 встречается 1 раз 
//                                         6 встречается 2 раза

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      result[i, j] = new Random().Next(minValue, maxValue + 1);
  return result;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]} ");
    Console.WriteLine();
  }
}

int[] GetRowArray(int[,] array)
{
  int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
  int index = 0;
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      newArray[index] = array[i, j];
      index++;
    }
  return newArray;
}

void SortArray(int[] inArray)
{
  for (int i = 0; i < inArray.Length; i++)
  {
    for (int j = i + 1; j < inArray.Length; j++)
    {
      if (inArray[i] > inArray[j])
      {
        int k = inArray[i];
        inArray[i] = inArray[j];
        inArray[j] = k;
      }
    }
  }
}

void FreqArray(int[] array)
{
  int count = 1;
  for (int i = 0; i < array.Length-1; i++)
  {
    if (array[i] == array[i + 1])
    {
      count++;
    }
    else
    {
      Console.WriteLine($"{array[i]} встречается {count} раз");
      count = 1;
    }
  }
  Console.WriteLine($"{array[array.Length-1]} встречается {count} раз");
}

Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 10);
PrintArray(myArray);

int[] arr = GetRowArray(myArray);
SortArray(arr);

FreqArray(arr);