// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int s = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[] array = GetArray(s, min, max);

Console.WriteLine(String.Join(" ", array));

int[] SumArray(int[] arr)
{
  // int[] arr1 = new int[arr.Length];
  
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < 0)
    {
      arr[i] = Math.Abs(arr[i]);
    }
    else
    { 
      arr[i] = -arr[i];
    }
  }
  return arr;
}

int[] arr1 = SumArray(array);
Console.WriteLine(String.Join(" ", arr1));







// int[] GetArray(int size, int minValue, int maxValue)
// {
//   int[] res = new int[size];

//   for (int i = 0; i < size;i++)
//   {
//     res[i] = new Random().Next(minValue, maxValue + 1);
//   }
//   return res;
// }

// int[] rev(int[] mas) 
// {
//     for (int i=0; i<mas.Length; i++ )
//    {
//         mas[i]*=-1;
//     }
//     return mas;
// }

// int[] array = GetArray(5,-10,11);

// Console.WriteLine(String.Join(" ", array));

// Console.WriteLine(String.Join(" ", rev(array)));
