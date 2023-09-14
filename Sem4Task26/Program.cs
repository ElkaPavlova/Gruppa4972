// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 1) ReadData
// 2) PrintResult
// 3) NumDigits
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

int NumDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num = num/10;

    }

    return count;
}

int n = ReadData("Введите число: ");
int res = NumDigits(n);
PrintResult("Количесто цифр:" + res);
