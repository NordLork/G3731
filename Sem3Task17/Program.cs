// Задача №17
// Напишите программу, которая принимает 
// на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату X точки: ");
// int coordX = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введите координату Y точки: ");
// int coordY = int.Parse(Console.ReadLine()??"0");

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Метод теста координаты на четверть
void PrintQuterTest(int X, int Y)
{
  if (X > 0 && Y > 0) Console.WriteLine("Точка в четверти 1");
  if (X > 0 && Y < 0) Console.WriteLine("Точка в четверти 2");
  if (X < 0 && Y < 0) Console.WriteLine("Точка в четверти 3");
  if (X < 0 && Y > 0) Console.WriteLine("Точка в четверти 4");
}

int coordX = ReadData("Введите координату X точки:");
int coordY = ReadData("Введите координату Y точки:");
PrintQuterTest(coordX, coordY);