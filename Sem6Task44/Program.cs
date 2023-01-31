// Задача №44
// Не используя рекурсию, выведите 
// первые N чисел Фибоначчи. Первые 
// два числа Фибоначчи: 0 и 1.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Метод Фибоначчи
int[] Fibonacci(int num)
{
  int[] arr = new int[num];
  arr[0] = 0;
  arr[1] = 1;
  for (int i = 2; i < num; i++)
  {
    arr[i] = arr[i - 1] + arr[i - 2];
  }
  return arr;
}

//Метод выводит на экран массив
void Print1DArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

int num = ReadData("Введите число: ");
Print1DArray(Fibonacci(num));
