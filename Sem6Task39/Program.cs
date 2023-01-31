// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

//Метод генерирует массив
int[] Gen1DArray(int len, int minValue, int maxValue)
{
  int[] arr = new int[len];
  Random gen = new Random();
  for (int i = 0; i < len; i++)
  {
    arr[i] = gen.Next(minValue, maxValue);
  }
  return arr;
}

//Метод переворачивает массив
void ReverseArray(int[] arr)
{
  for (int i = 0; i < arr.Length / 2; i++)
  {
    int temporary = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temporary;
  }
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

int[] arr = Gen1DArray(10, 0, 10);
Print1DArray(arr);
ReverseArray(arr);
Print1DArray(arr);
