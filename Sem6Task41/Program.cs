// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа 
// следит за нажатиями с клавиатуры и выдает сколько 
// чисел больше 0 было введено.

// Запрос ручного ввода массива
int[] ReadArray(string msg)
{
  string str = string.Empty;
  while ((str == string.Empty) || (str == " "))
  {
    Console.Write(msg);
    str = Console.ReadLine() ?? "0";
  }
  int[] arr = str.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
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

// Считаем элементы больше 0
int CountElem(int[] arr)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
    {
      res++;
    }
  }
  return res;
}

// Метод печати результата пользователя
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int[] array = ReadArray("Введите элементы массива (через пробел): ");
// Console.WriteLine();
Print1DArr(array);
int count = CountElem(array);
PrintData($"Количество элементов массива больше 0 равно {count}.");
