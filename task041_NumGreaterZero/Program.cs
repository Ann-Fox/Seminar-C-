//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// решение с обьявлением массива/параметров
// int[] GetArray(int size, int minValue, int maxValue)
// {
//   int[] res = new int[size];

//   for (int i = 0; i < size; i++)
//   {
//     res[i] = new Random().Next(minValue, maxValue + 1);
//   }
//   return res;
// }

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //готовое решение - ввод с клавиатуры https://www.cyberforum.ru/csharp-beginners/thread2967684.html

int NumGreaterZero(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) count++;
  }
  return count;
}

// int[] myArray = GetArray(5, -5, 3);
int numZero = NumGreaterZero(arr);
// Console.WriteLine(String.Join(" ",GetArray(myArray)));

Console.WriteLine($"[{String.Join(" ", arr)}] -> {numZero}");