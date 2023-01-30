// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки и методом 
// подсчета, а затем найдите разницу между первым и 
// последним элементом. Для задачи со звездочкой 
// использовать заполнение массива целыми числами.


// Запрос значения целого
int ReadDataInt(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Запрос значения вещественного
double ReadData(string msg)
{
  Console.Write(msg);
  return double.Parse(Console.ReadLine() ?? "0");
}

// Вывод значения
void PrintData(string res)
{
  Console.WriteLine(res);
}

// Генерируем вещественный массив 
double[] Gen1DArray(int len, double minValue, double maxValue)
{
  double[] arr = new double[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().NextDouble();
    arr[i] = minValue + (arr[i] * (maxValue - minValue));
  }
  return arr;
}

// Вывод массива с точностью до тысячных
void Print1DArr(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(Math.Round(arr[i], 3) + ", ");
  }
  Console.WriteLine(Math.Round(arr[arr.Length - 1], 3) + "]");
}

// Метод разницы между максимальным и минимальным элементами массива
double minMax(double[] arr)
{
  double max = double.MinValue;
  double min = double.MaxValue;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
  }
  return (max - min);
}


int len = ReadDataInt("Введите длинну массива: ");
double num1 = ReadData("Введите минимум для вещественных значений в массиве в формате 0,00: ");
double num2 = ReadData("Введите максимум для вещественных значений в массиве в формате 0,00: ");
double[] testArr = Gen1DArray(len, num1, num2);
Print1DArr(testArr);
double count = minMax(testArr);
PrintData("Разница между максимальным и минимальным элементами массива (с точностью до тысячных): " + Math.Round(count, 3));
