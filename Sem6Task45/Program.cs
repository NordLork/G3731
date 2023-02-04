// Задача №45
// Напишите программу, которая будет создавать 
// копию заданного одномерного массива с 
// помощью поэлементного копирования.

// Запрос значения
int ReadData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
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

// Поэлементное копирование заданного массива
int[] copyArray(int[] arr)
{
  int[] copy = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    copy[i] = arr[i];
  }
  return copy;
}

int len = ReadData("Введите длинну массива: ");
int num1 = ReadData("Введите минимум для значений в массиве: ");
int num2 = ReadData("Введите максимум для значений в массиве: ");
int[] testArr = Gen1DArray(len, num1, num2);
Print1DArr(testArr);
Console.WriteLine();
int[] copyArr = copyArray(testArr);
Console.WriteLine();
Print1DArr(copyArr);



// Вариант 2


// int length = ReadData("Задайте длину массива: ");
// int[] array = CreateRandomArray(length);
// Print1DArray(array);
// PrintResult("Копия массива");
// Print1DArray(MakeArrayCopy(array));

// PrintResult("Копия массива Clone");
// Print1DArray((int[])array.Clone());


// // Получение данных от пользователя и преобразование в число
// int ReadData(string text)
// {
//   Console.Write(text);
//   int number = int.Parse(Console.ReadLine()??"0");
//   return number;
// }

// // Вывод результата в консоль
// void PrintResult(string data)
// {
//     Console.WriteLine(data);
// }

// // Создание и заполнение массива числами
// int[] CreateRandomArray(int leng)
// {
//     int[] array = new int[leng];
//     Random rnd = new Random();

//     for (int i = 0; i < leng; i++)
//     {
//         array[i] = rnd.Next(-1000, 1000);
//     }
//     return array;
// }

// // Вывод массива в консоль
// void Print1DArray(int[] arr)
// {
//     Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
// }

// int[] MakeArrayCopy(int[] arr)
// {
//   int[] rev = new int[arr.Length];
//   for(int i = 0; i < arr.Length; i++)
//   {
//     rev[i] = arr[i];
//   }
//   return rev;
// }
