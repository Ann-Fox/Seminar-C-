// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ArithmeticMeanColumn(int[,] array)
{
  int[] summ = new int[array.GetLength(1)];
  double arithmeticSum = 1;

  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      summ[i] += array[j, i];
    }
    arithmeticSum = Math.Round(summ[i] * 1.0 / array.GetLength(0), 1);
    Console.Write($"{arithmeticSum}  ");
  }
}

int[,] myArray = GetArray(3, 5, 0, 10);
PrintArray(myArray);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
ArithmeticMeanColumn(myArray);