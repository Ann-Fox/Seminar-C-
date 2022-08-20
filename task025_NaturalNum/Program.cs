// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Реализовать функцию возведения в степень самостоятельно!

// Вариант 1 
// Вопрос: как реализовать данный вывод  "3, 5 -> 243" в консоль?

int NaturalNumber(int a, int b)
{
  int N = 1;
  for (int i = 1; i <= b; i++)
  {
    N *= a;
  }
  return N;
}

int res1 = NaturalNumber(3, 5);
int res2 = NaturalNumber(2, 4);

Console.WriteLine(res1);
Console.WriteLine(res2);



// Вариант 2
// Console.Write("Введите число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите число: ");
// int num2 = int.Parse(Console.ReadLine());

// int NaturalNumber(int a, int b)
// {
//   int N = 1;
//   for (int i = 1; i <= b; i++)
//   {
//     N *= a;
//   }
//   return N;
// }

// Console.Write($"{num1}, {num2} -> {NaturalNumber(num1, num2)}");