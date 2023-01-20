// Задача №22
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.

// Таблица квадратов, кубов
// Console.WriteLine("Число\tКвадрат\tКуб");
// for (int i = 1; i < 10; i++)
// {
//   Console.WriteLine("{0}\t{1}\t{2}", i, Math.Pow(i,2), Math.Pow(i, 3));
// }

// // Ввод данных
// Console.Write("Введите N: ");
// int num = int.Parse(Console.ReadLine() ?? "0");

// // вывод нахождения степени чисел от 1 до N
// string LineBuilder(int n,int p)
// {   
//   string s="";
//     for (int i = 1; i < n; i++)
//     {
//       s+=Math.Pow(i, p).ToString()+"\t ";
//     }
//     return s;
// }

// // Вывод данных
// Console.WriteLine(LineBuilder(num,1));
// Console.WriteLine(LineBuilder(num,2));

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t ";
    }
    return s;
}

// Ввод данных
int num = ReadData("Введите N: ");

//Собираем первую строчку таблицы
string line1 = LineBuilder(num, 1);
//Собираем вторую строчку таблицы
string line2 = LineBuilder(num, 2);

// Вывод данных
PrintData(line1,line2);