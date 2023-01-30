// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька

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

// Считаем элементы
int CountElem(int[] arr)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (Test(arr[i]))
    {
      res++;
    }
  }
  return res;
}

// Тетстируем элемент на чётность
bool Test(int n)
{
  return (n % 2 == 0);
}

// Метод пузырька
int[] BubbleSort(int[] arr)
{
  int swap = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    for (int j = i + 1; j < arr.Length; j++)
    {
      if (arr[i] > arr[j])
      {
        swap = arr[i];
        arr[i] = arr[j];
        arr[j] = swap;
      }
    }
  }
  return arr;
}

int len = ReadData("Введите длинну массива: ");
int[] testArr = Gen1DArray(len, 100, 999);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество чётных элементов:" + count);
int[] convArr = BubbleSort(testArr);
Console.WriteLine();
PrintData("Массив после сортировки методом пузырька:");
Print1DArr(convArr);
