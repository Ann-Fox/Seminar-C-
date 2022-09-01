// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      result[i, j] = new Random().Next(minValue, maxValue + 1);
  return result;
}

void CorrectArray(int[,] array)
{
  int[,] result = new int[array.GetLength(0), array.GetLength(1)];

  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)

      //0,0  0,1  0,2      0,0  1,0  2,0
      //1,0  1,1  1,2      0,1  1,1  2,1
      //2,0  2,1  2,2      0,2  1,2  2,2

      if (array.GetLength(0) == array.GetLength(1))
      {
        result[i,j] = array[j, i];
      }
      else
      {
        Console.Write("Error");
      }

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
Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 10);

PrintArray(myArray);
CorrectArray(myArray);

Console.WriteLine();
PrintArray(myArray);

// int[,] NewArray(int[,] array)
// {
//     int[,] tmp = new int[array.GetLength(0), array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             tmp[i, j] = array[j, i];
//         }
//     }
//     return tmp;
// }

// int[,] myArray = GetArray(m, n);
// PrintArray(myArray);
// Console.WriteLine();
// if (myArray.GetLength(0) == myArray.GetLength(1))
// {
//     PrintArray(NewArray(myArray));
// }
// else
//     Console.Write("Кол-во столбцов не совпадает с кол-во строк!");
