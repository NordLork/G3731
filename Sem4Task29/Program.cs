// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// * Ввести с клавиатуры длину массива и диапазон значений элементов
// Дополнительно: Написать программу которая 
// из имен через запятую выберет случайное имя 
// и выведет в терминал Игорь, Антон, Сергей -> Антон 
// Подсказка: Для разбора строки использовать 
// метод string.split(). Для выбора случайного 
// имени метод Random.Next(1,<длина массива имен>+1).

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите длину массива: ");
int arrSta = ReadData("Введите начало диапазона выбора случайных чисел (включительно): ");
int arrEnd = ReadData("Введите конец диапазона выбора случайных чисел (включительно): ");
int[] arr = Gen1DArr(arrLen, arrSta, arrEnd);
Print1DArr(arr);
