// Задача 4: Напишите программу,
// которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();
// Считываем данные с консоли 3 число
string? inputNum3 = Console.ReadLine();
// Проверим, чтобы данные были не пустыми
if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
  // Парсим введённое 1 число
  int number1 = int.Parse(inputNum1);
  // Парсим введённое 2 число
  int number2 = int.Parse(inputNum2);
  // Парсим введённое 3 число
  int number3 = int.Parse(inputNum3);
  // Сравниваем числа
  if (number1 > number2)
  {
    if (number1 > number3)
    {
      Console.Write("Maximum: ");
      Console.WriteLine(number1);
    }
    else
    {
      Console.Write("Maximum: ");
      Console.WriteLine(number3);
    }
  }
  else
  {
    if (number2 > number3)
    {
      Console.Write("Maximum: ");
      Console.WriteLine(number2);
    }
    else
    {
      Console.Write("Maximum: ");
      Console.WriteLine(number3);
    }
  }
}