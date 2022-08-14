// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//2/1
//3/4

Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());

// if (number == 1) {
//   Console.Write("x > 0, y > 0");
//   }
// else if (number == 2) {
//   Console.Write("x < 0, y > 0");
//   }
// else if (number == 3) {
//   Console.Write("x < 0, y < 0");
//   }
// else if (number == 4) {
//   Console.Write("x > 0, y < 0");
//   } 
// else {
//   Console.WriteLine("Такой четверти нет");
//   }

switch (number)
{
  case (1):
    Console.Write("x > 0, y > 0");
    break;
  case (2):
    Console.Write("x < 0, y < 0");
    break;
  case (3):
    Console.Write("x < 0, y < 0");
    break;
  case (4):
    Console.Write("x > 0, y < 0");
    break;
  default:
    Console.WriteLine("Такой четверти нет");
    break;
}