// Задача 2: Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();
// Проверим, чтобы данные были не пустыми
if (inputNum1 != null && inputNum2 != null)
{
  // Парсим введённое 1 число
  int number1 = int.Parse(inputNum1);
  // Парсим введённое 2 число
  int number2 = int.Parse(inputNum2);
  // Срвниваем числа
  if (number1 > number2)
  {
    Console.WriteLine("Первое число больше второго!");
  }
  else
  {
    Console.WriteLine("Второе число больше первого!");
  }
}