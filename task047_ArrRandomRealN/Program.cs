// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n)
{
  double[,] result = new double[m, n];

  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      // Вопрос: можно ли задать интервал вручную? Как мы делалаи с int? 
      // min/max значения? Например -10..+20 или интервал может быть только -n .. +n?
      result[i, j] = Math.Round(((new Random().NextDouble() - 0.5) * 200), 1); //-100 ... 100
  return result;
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]} ");
    Console.WriteLine();
  }
}

double[,] myArray = GetArray(3, 4);
double[,] myArray2 = GetArray(5, 4);

PrintArray(myArray);
Console.WriteLine();
PrintArray(myArray2);