// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      result[i, j] = new Random().Next(minValue, maxValue + 1); //[1,9]
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

int[,] SortArray(int[,] arr)
{
  int temp;
 int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = j + 1; k < arr.GetLength(1); k++)
      {
        if (arr[i, j] < arr[i, k])
        {
          temp = arr[i, k];
          arr[i, k] = arr[i, j];
          arr[i, j] = temp;
           
        }
      }
 result[i,j] += arr[i, j];
    }

  }
  return result;
}

int[,] myArray = GetArray(4, 5, 1, 9);
PrintArray(myArray);
Console.WriteLine();
SortArray(myArray);
PrintArray(myArray);
