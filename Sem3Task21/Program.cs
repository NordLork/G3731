// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Метод читает строку от пользователя
string ReadDataStr(string msg)
{
  Console.WriteLine(msg);
  return Console.ReadLine();
}

// Метод получения координат из строки
int[] coord(string str)
{
  int[] res = str.Split("(),AB;".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
  return res;
}

// Метод печати результата пользователя
void PrintData(string msg, double res)
{
  Console.WriteLine(msg + res);
}

// Метод вычисления расстояния между точками в 3D простанстве
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
  double res = 0;
  res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
  return res;
}

// Вариант 1
// // Вводим координаты точек
// int coordX1 = ReadData("Введите координтату X1: ");
// int coordY1 = ReadData("Введите координтату Y1: ");
// int coordZ1 = ReadData("Введите координтату Z1: ");
// int coordX2 = ReadData("Введите координтату X2: ");
// int coordY2 = ReadData("Введите координтату Y2: ");
// int coordZ2 = ReadData("Введите координтату Z2: ");
// // Вычисляем расстояние
// double len = CalcLen(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2);
// // Вывод результата
// PrintData("Расстояние между точками: ", len);

// Вариант 2

string coordAB = ReadDataStr("Введите координтаты точек в формате: A(x,y,z);B(x,y,z)");
int[] coordXY = coord(coordAB);
if (coordXY.Length == 6)
{
  // Проверка заполнения массива координат
  // for (int i = 0; i < 6; i++) { Console.WriteLine(coordXY[i]);}
  // Вычисляем расстояние
  double len = CalcLen(coordXY[0], coordXY[3], coordXY[1], coordXY[4], coordXY[2], coordXY[5]);
  // Вывод результата
  PrintData("Расстояние между точками: ", len);
}
else
{
  Console.WriteLine("Координаты введены не корректно.");
}