// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// Вариант 1
// Console.Write("Введите трёхзначное число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// if ((num > 99) && (num < 1000))
// {
//   int res = num / 10;
//   res = res % 10;
//   Console.WriteLine("Вторая цифра трёхзначного числа: " + res);
// }
// else
// {
//   Console.WriteLine("Число не трёхзначное.");
// }

// Вариант 2
Console.Write("Введите трёхзначное число: ");
char[] digits = Console.ReadLine().ToCharArray();
// Проверка ввода
if (digits.Length == 3)
{
  // Выводим цифру 
  Console.WriteLine("Вторая цифра трёхзначного числа: " + digits[1]);
}
else
{
  Console.WriteLine("Число не трёхзначное.");
}