// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int size)
{
  int[] array = new int[size];

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
  // Console.WriteLine($"[{String.Join(", ", array)}]"); //вывод массива
  return array;
}


int EvenNumArray(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      count++;
    }
  } 
  Console.WriteLine($"[{String.Join(", ", arr)}] -> {count}");
  return count;

}

EvenNumArray(Array(5));
EvenNumArray(Array(6));

