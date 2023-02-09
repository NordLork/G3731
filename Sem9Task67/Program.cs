// ---------------------------------------------------------------------
//                                 Задача 67
// примает на вход число и возвращает сумму числа
// ---------------------------------------------------------------------


int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, принимает число, выводит в консоль
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

// Метод, принимает строку, выводит в консоль
static void PrintResultStr(string line)
{
    Console.WriteLine(line);
}

//Сумма цифр в числе рекурентно
int RecSumDig(int n)
{
    if(n<=10)return n;
    return n%10+RecSumDig(n/10);
}

//Сумма цифр в числе 
int SumDig(int n)
{
    int res = 0;
    while(n>0)
    {
        res=res+n%10;
        n=n/10;
    }
    return res;
}


int numberN = ReadData("Enter number N: ");
DateTime d1 = DateTime.Now;
int Sum1 = RecSumDig(numberN);
PrintResult(Sum1);
PrintResultStr("Решение суммы цифр в числе рекурентно: " + (DateTime.Now - d1));
//Console.WriteLine();
DateTime d2 = DateTime.Now;
int Sum2 = SumDig(numberN);
PrintResult(Sum2);
PrintResultStr("Решение суммы цифр циклом: " + (DateTime.Now - d2));
