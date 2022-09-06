// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductMatrix(int[,] arr1, int[,] arr2)
{
  int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];

  for (int i = 0; i < arr1.GetLength(0); i++)
  {
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
      for (int k = 0; k < arr2.GetLength(0); k++)
      {
        result[i, j] += arr1[i, k] * arr2[k, j];
      }
    }
  }
  return result;
}

int N = 2;
int M = 2; //Две матрицы можно перемножить если количество столбцов первой матрицы (N) равно количеству строк второй матрицы (N).

Console.WriteLine();

int[,] matrix1 = GetArray(M, N, 1, 10);
PrintArray(matrix1);
Console.WriteLine();

int[,] matrix2 = GetArray(N, M, 1, 10);
PrintArray(matrix2);
Console.WriteLine();

int[,] productMatrix = ProductMatrix(matrix1, matrix2);
PrintArray(productMatrix);