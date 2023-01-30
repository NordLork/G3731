// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

// Запрос значения
int ReadData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод значения
void PrintData(string res)
{
  Console.WriteLine(res);
}

// Генерируем массив
int[] Gen1DArray(int len, int minValue, int maxValue)
{
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(minValue, maxValue + 1);
  }
  return arr;
}

// Вывод массива
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

int sumPos(int[] arr)
{
  int res = 0;
  for (int i = 1; i < arr.Length; i = i + 2) res += arr[i];
  return res;
}

int len = ReadData("Введите длинну массива: ");
int num1 = ReadData("Введите минимум для значений в массиве: ");
int num2 = ReadData("Введите максимум для значений в массиве: ");
int[] testArr = Gen1DArray(len, num1, num2);
Print1DArr(testArr);
int count = sumPos(testArr);
PrintData("Сумма чётных элементов:" + count);
