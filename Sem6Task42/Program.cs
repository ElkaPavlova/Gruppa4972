// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string DecToBin(int num) //перевод в двоичную систему счисления
{
    string line = String.Empty;
    while (num > 0)
    {
        line = num%2 + line;
        num = num/2;
    }

    return line;
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

int number = ReadData("Введите число: ");
string lineNew = DecToBin(number);
PrintResult("В двоичной системе счисления - "+lineNew);