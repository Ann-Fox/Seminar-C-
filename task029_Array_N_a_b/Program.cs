// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

void RandArray(int size, int a, int b)
{
  int[] array = new int[size];

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(a, b);
  }
  Console.WriteLine($"{size}, {a}, {b} -> [{String.Join(",", array)}]");
}

RandArray(5, 0, 20);
RandArray(3, 1, 35);
RandArray(5, 1, 7);