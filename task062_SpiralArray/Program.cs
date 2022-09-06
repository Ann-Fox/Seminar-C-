// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Решние в интернете: 
// https://www.cyberforum.ru/java-beginners/thread1174715.html
// https://replit.com/@Anastasia1012/Zadacha-62-Zapolnitie-spiralno-massiv-4-na-4?v=1#main.cs

// Задача не реализованаю.
 int[,] GetArray(int size)
    {
      int [,] result = new int[size, size];
      int i = 0;
      int j = 0;
      int rowE = size - 1;
      int columnE = size - 1;
      int rowS = 0;
      int columnS = 0;
      bool left = true;
      bool top = true;
      int count = 0;
      while (count < size * size)
      {
        
        result[i, j] = count;
        count++;
        // идем вправо
        if (left && top)
        {
          if (j == columnE)
          {
            rowS++;
            top = true;
            left = false;
            i++;
            continue;
          }
          else
          {
            j++;
              continue;
          }
        }

        //идем вниз
        if (!left && top)
        {
          if (i == rowE)
          {
            columnE--;
            top = false;
            left = false;
            j--;
            continue;
          }
          else
          {
            i++;
            continue;
          }
        }
        //идем влево
        if (!left && !top)
        {
          if (j == columnS)
          {
            rowE--;
            top = false;
            left = true;
            i--;
            continue;
          }
          else
          {
            j--;
            continue;
      }
    }
        //Идем вверх
       if (left && !top)
        {
          if (j == rowS)
          {
            columnS++;
            top = true;
            left = true;
            j++;
            continue;
          }
          else
          {
            i--;
            continue; 
          }
        }
      }
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

int[,] myArray = GetArray(4);
PrintArray(myArray);


