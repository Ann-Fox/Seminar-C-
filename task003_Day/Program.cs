// Задача 3
Console.Write("Введите число от 1 до 7: ");

int day = int.Parse(Console.ReadLine());

switch(day)
{
  case 1: 
    Console.WriteLine($"{day} -> Monday");
    break;
  case 2:
    Console.WriteLine($"{day} -> Tuesday");
    break;
  case 3:
    Console.WriteLine($"{day} -> Wednesday");
    break;
  case 4:
    Console.WriteLine($"{day} -> Thursday");
    break;
  case 5:
    Console.WriteLine($"{day} -> Friday");
    break;
  case 6:
    Console.WriteLine($"{day} -> Saturday");
    break;
  case 7:
    Console.WriteLine($"{day} -> Sunday");
    break;
}
