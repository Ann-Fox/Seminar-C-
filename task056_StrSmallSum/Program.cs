// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumRow(int[,] arr)
{
  int minSum = 0;
  int row = 0;

  for (int i = 0; i < arr.GetLength(1); i++)
  {
    minSum += arr[0, i];
  }
  Console.WriteLine($"Сумма 0-строки: {minSum}");

  for (int i = 1; i < arr.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum = sum + arr[i, j];
    }

    Console.WriteLine($"Сумма {i}-строки: {sum}");

    if (minSum > sum)
    {
      minSum = sum;
      row = i;
    }
  }
  Console.WriteLine($"Номер строки с наименьшей суммой эелементов: {row}");
}

int[,] myArray = GetArray(5, 3, 1, 9);
PrintArray(myArray);
Console.WriteLine();
MinSumRow(myArray);
