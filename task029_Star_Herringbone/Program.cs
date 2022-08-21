// Задача “со звездочкой”: (необязательное) Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

// void Star(int N){

Console.WriteLine();
for (int i = 1; i < 10; i++)
{

  for (int star = 0; star < i; star++)
  {
    Console.Write("*");
  }

  Console.WriteLine();
}
