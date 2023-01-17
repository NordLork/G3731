// Задача №16
// Напишите программу, которая принимает 
// на вход два числа и проверяет, 
// является ли одно число квадратом другого.


// Вариант 1

// Задаём метод (void с англ. "пустота")
void TestSQRT(int i, int j)
{
  if ((int)Math.Pow(i,2)==j)
  {
    Console.WriteLine("да, число "+j+" является квадратом числа "+i);
  }
  else
  {
    Console.WriteLine("число "+j+" не является квадратом числа "+i);
  }
}
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0"); // Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0"); // Ввод второго числа
//сравнение возведённого в квадрат числа с другим числом
TestSQRT(num1,num2);
TestSQRT(num2,num1);


// Вариант 2

// Console.WriteLine("input yor nums: ");
// // Вводим данные с консоли
// int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
// int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
// //сравнение возведённого в квадрат числа с другим числом
// if ((int)Math.Pow(num1, 2) == num2)
// {
//     Console.Write("да, число "+num2+" является степенью числа "+num1);//вывод согласия
// }
// else
// {
//     if ((int)Math.Pow(num2, 2) == num1)
//     {
//         Console.Write("да, число "+num1+" является степенью числа "+num2);//вывод согласия
//     }
//     else
//     {
//         Console.Write("Нет, числа "+num1+" и "+num2+" не являются чьей либо степенью");//вывод не согласия
//     }
// }