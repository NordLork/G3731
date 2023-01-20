// Задача №20
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печати результата пользователя
void PrintData(string msg, double res)
{
  Console.WriteLine(msg + res);
}

// Метод вычисления расстояния между точками в 2D простанстве
double CalcLen(int x1, int x2, int y1, int y2)
{
  double res = 0;
  res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
  return res;
}

// Вводим координаты точек
int coordX1 = ReadData("Введите координтату X1: ");
int coordY1 = ReadData("Введите координтату Y1: ");
int coordX2 = ReadData("Введите координтату X2: ");
int coordY2 = ReadData("Введите координтату Y2: ");

// Вычисляем расстояние
double len = CalcLen(coordX1, coordX2, coordY1, coordY2);

// Вывод результата
PrintData("Расстояние между точками: ", len);

// PrintData("Расстояние между точками: ", CalcLen(
//   ReadData("Введите координтату X1: "),
//   ReadData("Введите координтату Y1: "),
//   ReadData("Введите координтату X2: "),
//   ReadData("Введите координтату Y1: ")));