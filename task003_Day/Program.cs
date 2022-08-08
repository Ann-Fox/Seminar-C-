// Задача 3
Console.Write("Введите число от 1 до 7: ");

int day = int.Parse(Console.ReadLine());

if (day == 1)
{
  Console.WriteLine($"{day} -> Monday");
}
else if (day == 2)
{
  Console.WriteLine($"{day} -> Tuesday");
}
else if (day == 3)
{
  Console.WriteLine($"{day} -> Wednesday");
}
else if (day == 4)
{
  Console.WriteLine($"{day} -> Thursday");
}
else if (day == 5)
{
  Console.WriteLine($"{day} -> Friday");
}
else if (day == 6)
{
  Console.WriteLine($"{day} -> Saturday");
}
else if (day == 7)
{
  Console.WriteLine($"{day} -> Sunday");
}