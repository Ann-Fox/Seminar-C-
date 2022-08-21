// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


int Summ(int a)
{
  int i = 0;
  int sum = 0;

  // int b = 0;
  while (a > 0)
  {
    sum += (a % 10);  //  b = a % 10;
    a = a / 10;
  }
  return sum;
}

int res1 = Summ(num);
Console.WriteLine($"{num} -> {res1}");

// int res2 = Summ(82);
// Console.WriteLine(res2);

// int res3 = Summ(9012);
// Console.WriteLine(res3);
