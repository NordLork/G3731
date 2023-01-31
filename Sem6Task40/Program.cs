// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Метод проверяет, может ли существовать треугольник с заданными сторонами
void Triangle(int a, int b, int c)
{
  if ((a + b > c) && (b + c > a) && (a + c > b))
  {
    Console.WriteLine("Треугольник существует.");
  }
  else
  {
    Console.WriteLine("Треугольник не существует.");
  }
}

int a = ReadData("Введите первое число: ");
int b = ReadData("Введите второе число: ");
int c = ReadData("Введите третье число: ");
Triangle(a, b, c);
