// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Считываем данные с консоли число
Console.Write("Введите N: ");
string? inputNum = Console.ReadLine();
// Проверим, чтобы данные были не пустыми
if (inputNum != null)
{
  // Парсим введённое число
  int num = int.Parse(inputNum);
  // Вводим переменную для получения результата
  string? rez = string.Empty;
  // Проверим удовлетворяет ли число условию задачи
  if (num > 1)
  {
    // Запускаем цикл for сбора четных значений до введённого числа
    for (int i = 2; i < num; i = i + 2)
    {
      rez = rez + i + ", ";
    }
    if (num % 2 == 0)
    {
      rez = rez + num;
    }
    else
    {
      //Удаляем последние " ," при нечётном числе
      rez = rez.TrimEnd(' ');
      rez = rez.TrimEnd(',');
      // int lastIndex = rez.LastIndexOf(',');
      // rez = rez.Remove(lastIndex, 2);
    }
    Console.WriteLine(rez);
  }
}