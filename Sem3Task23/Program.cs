// Задача 23
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Выводим результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// Вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t ";
    }
    return s;
}

// Вывод нахождения степени чисел от 1 до N для таблицы
string LineBuilderTabl(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += "|"+Math.Pow(i, p).ToString() + "\t ";
    }
    s += "|";
    return s;
}

// Вывод результата таблицей в консоли
void PrintTabl(string msg1, string msg2, string msg3)
{
    int tableWidth=msg1.Length;
    Console.WriteLine(new string('—', 2*tableWidth));
    Console.WriteLine(msg1);
    Console.WriteLine(new string('—', 2*tableWidth));
    Console.WriteLine(msg2);
    Console.WriteLine(new string('—', 2*tableWidth));
    Console.WriteLine(msg3);
    Console.WriteLine(new string('—', 2*tableWidth));   
}

//Вариант 1
// // Ввод данных
// int num = ReadData("Введите N: ");
// //Собираем первую строчку таблицы
// string line1 = LineBuilder(num, 1);
// //Собираем вторую строчку таблицы
// string line2 = LineBuilder(num, 3);
// // Вывод данных
// PrintData(line1,line2);

// Вариант 2
// Ввод данных
int num = ReadData("Введите N: ");
//Собираем первую строчку таблицы
string line1 = LineBuilderTabl(num, 1);
// Собираем вторую строчку таблицы
string line2 = LineBuilderTabl(num, 2);
// Собираем третью строчку таблицы
string line3 = LineBuilderTabl(num, 3);
// Вывод данных
PrintTabl(line1,line2,line3);