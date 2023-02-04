// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Запрос ввода
double ReadData(string msg)
{
  Console.Write(msg);
  return Convert.ToDouble(Console.ReadLine() ?? "0");
}

// Определение пересечения прямых
(double x, double y) getXY(double k1, double b1, double k2, double b2)
{
  double getX = (b2 - b1) / (k1 - k2);
  double getY = k1 * getX + b1;
  getX = Math.Round(getX, 3);
  getY = Math.Round(getY, 3);
  var result = (x: getX, y: getY);
  return result;
}

// Метод печати результата пользователя
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

double k1 = ReadData("Введите k1: ");
double b1 = ReadData("Введите b1: ");
double k2 = ReadData("Введите k2: ");
double b2 = ReadData("Введите b2: ");
var coord = getXY(k1, b1, k2, b2);
PrintData($"Пересечение в точке: ({coord.x}; {coord.y})");



// Вариант 2

// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }
// // печать результата
// void PrintData (string prefix, string data) //разбили на две части вывод в консоль
// {
//      Console.WriteLine(prefix + data); //сначала выводим prefix + а потом данные data\
// }
// // Поиск точки пересечения двух прямых
// double[] PointFind (int k1, int b1, int k2, int b2)
// {
//     double[] outArr = new double[2];
//     double x = (double)(b2 - b1) / (double)(k1 - k2);
//     double y = k1 * x + b1;
//     outArr[0] = x;
//     outArr[1] = y;
//     return outArr;
// }
// //Ввод значения k1, b1, k2, b2
// int k1 =ReadData("Введите значение k1:");
// int b1 =ReadData("Введите значение b1:");
// int k2 =ReadData("Введите значение k2:");
// int b2 =ReadData("Введите значение b2:");

// //Вычисляем точку пересечения
// double[]Point = PointFind (k1, b1, k2, b2);
// //Выводим на экран координату точки пересечения
// PrintData ("Точка пересечения двух прямых: ", $"({Point[0]};{Point[1]})");

// // но почему то не получается то что надо..