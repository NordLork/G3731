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
