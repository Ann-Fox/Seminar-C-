﻿// Задача “со звездочкой”: (необязательное) Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

// void Star(int N){
for (int i = 1; i < 10; i++)
{
  for (int m = 0; m < i; m++)
  {
    Console.Write("*");
  }
  Console.WriteLine();
}
// }