// Задача №14
// Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли 
// оно одновременно 7 и 23.


// Вариант 1

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
int res1 = num1 % 7;
int res2 = num1 % 23;
// Для сложных условий: 
// Логиеское "и" &&,
// Логиеское "или" ||
if ((res1 == 0) && (res2 == 0))
{
  Console.WriteLine("Кратно 7 и 23.");
}
else
{
  Console.WriteLine("Не кратно 7 и 23.");
}


// Вариант 2

// int num1 = int.Parse(Console.ReadLine() ?? "0");

// int res1 = num1 % 7;
// int res2 = num1 % 23;
// if ((res1 == 0) && (res2 == 0))
// {
//   Console.WriteLine("Кратное ");
// }
// else
// {
//   Console.WriteLine("Не кратно " + res1 + " " + res2);
// }